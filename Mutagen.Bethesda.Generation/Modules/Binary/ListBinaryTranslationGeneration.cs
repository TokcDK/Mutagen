﻿using Loqui;
using Loqui.Generation;
using Noggog;
using Mutagen.Bethesda.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mutagen.Bethesda.Generation
{
    public enum ListBinaryType
    {
        Amount,
        SubTrigger,
        Trigger,
        Frame
    }

    public class ListBinaryTranslationGeneration : BinaryTranslationGeneration
    {
        public virtual string TranslatorName => $"ListBinaryTranslation";

        const string AsyncItemKey = "ListAsyncItem";
        const string ThreadKey = "ListThread";

        public override string GetTranslatorInstance(TypeGeneration typeGen, bool getter)
        {
            var list = typeGen as ListType;
            if (!Module.TryGetTypeGeneration(list.SubTypeGeneration.GetType(), out var subTransl))
            {
                throw new ArgumentException("Unsupported type generator: " + list.SubTypeGeneration);
            }

            var subMaskStr = subTransl.MaskModule.GetMaskModule(list.SubTypeGeneration.GetType()).GetErrorMaskTypeStr(list.SubTypeGeneration);
            return $"{TranslatorName}<{list.SubTypeGeneration.TypeName(getter)}, {subMaskStr}>.Instance";
        }

        public override bool IsAsync(TypeGeneration gen, bool read)
        {
            var listType = gen as ListType;
            if (listType.CustomData.TryGetValue(ThreadKey, out var val) && ((bool)val)) return true;
            if (this.Module.TryGetTypeGeneration(listType.SubTypeGeneration.GetType(), out var keyGen)
                && keyGen.IsAsync(listType.SubTypeGeneration, read)) return true;
            return false;
        }

        public override void Load(ObjectGeneration obj, TypeGeneration field, XElement node)
        {
            var asyncItem = node.GetAttribute<bool>("asyncItems", false);
            var thread = node.GetAttribute<bool>("thread", false);
            var listType = field as ListType;
            listType.CustomData[ThreadKey] = thread;
            if (asyncItem && listType.SubTypeGeneration is LoquiType loqui)
            {
                loqui.CustomData[LoquiBinaryTranslationGeneration.AsyncOverrideKey] = asyncItem;
            }
        }

        private ListBinaryType GetListType(
            ListType list,
            MutagenFieldData data,
            MutagenFieldData subData)
        {
            if (list.MaxValue.HasValue)
            {
                return ListBinaryType.Amount;
            }
            else if (subData.HasTrigger)
            {
                return ListBinaryType.SubTrigger;
            }
            else if (data.RecordType.HasValue)
            {
                return ListBinaryType.Trigger;
            }
            else
            {
                return ListBinaryType.Frame;
            }
        }

        public override void GenerateWrite(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            Accessor writerAccessor,
            Accessor itemAccessor,
            Accessor errorMaskAccessor,
            Accessor translationMaskAccessor)
        {
            var list = typeGen as ListType;
            if (!this.Module.TryGetTypeGeneration(list.SubTypeGeneration.GetType(), out var subTransl))
            {
                throw new ArgumentException("Unsupported type generator: " + list.SubTypeGeneration);
            }

            if (typeGen.TryGetFieldData(out var data)
                && data.MarkerType.HasValue)
            {
                fg.AppendLine($"using (HeaderExport.ExportHeader(writer, {objGen.RegistrationName}.{data.MarkerType.Value.Type}_HEADER, ObjectType.Subrecord)) {{ }}");
            }

            var subData = list.SubTypeGeneration.GetFieldData();

            ListBinaryType listBinaryType = GetListType(list, data, subData);

            var allowDirectWrite = subTransl.AllowDirectWrite(objGen, typeGen);
            var isLoqui = list.SubTypeGeneration is LoquiType;
            var listOfRecords = !isLoqui
                && listBinaryType == ListBinaryType.SubTrigger
                && allowDirectWrite;

            using (var args = new ArgsWrapper(fg,
                $"{this.Namespace}ListBinaryTranslation<{list.SubTypeGeneration.TypeName(getter: true)}>.Instance.Write{(listOfRecords ? "ListOfRecords" : null)}"))
            {
                args.Add($"writer: {writerAccessor}");
                args.Add($"items: {itemAccessor.PropertyOrDirectAccess}");
                if (subTransl.DoErrorMasks)
                {
                    args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                }
                if (listBinaryType == ListBinaryType.Trigger)
                {
                    args.Add($"recordType: {objGen.RecordTypeHeaderName(data.RecordType.Value)}");
                }
                if (listOfRecords)
                {
                    args.Add($"recordType: {subData.TriggeringRecordSetAccessor}");
                }
                if (subTransl.DoErrorMasks)
                {
                    args.Add($"errorMask: {errorMaskAccessor}");
                }
                if (this.Module.TranslationMaskParameter)
                {
                    args.Add($"translationMask: {translationMaskAccessor}");
                }
                if (allowDirectWrite)
                {
                    args.Add($"transl: {subTransl.GetTranslatorInstance(list.SubTypeGeneration, getter: true)}.Write");
                }
                else
                {
                    args.Add((gen) =>
                    {
                        var listTranslMask = this.MaskModule.GetMaskModule(list.SubTypeGeneration.GetType()).GetTranslationMaskTypeStr(list.SubTypeGeneration);
                        gen.AppendLine($"transl: (MutagenWriter subWriter, {list.SubTypeGeneration.TypeName(getter: true)} subItem{(subTransl.DoErrorMasks ? ", ErrorMaskBuilder listErrorMask" : null)}) =>");
                        using (new BraceWrapper(gen))
                        {
                            subTransl.GenerateWrite(
                                fg: gen,
                                objGen: objGen,
                                typeGen: list.SubTypeGeneration,
                                writerAccessor: "subWriter",
                                translationAccessor: "listTranslMask",
                                itemAccessor: new Accessor($"subItem"),
                                errorMaskAccessor: $"listErrorMask");
                        }
                    });
                }
            }
        }

        public override void GenerateCopyIn(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            Accessor nodeAccessor,
            Accessor itemAccessor,
            Accessor errorMaskAccessor,
            Accessor translationMaskAccessor)
        {
            var list = typeGen as ListType;
            var data = list.GetFieldData();
            var subData = list.SubTypeGeneration.GetFieldData();
            if (!this.Module.TryGetTypeGeneration(list.SubTypeGeneration.GetType(), out var subTransl))
            {
                throw new ArgumentException("Unsupported type generator: " + list.SubTypeGeneration);
            }

            var isAsync = subTransl.IsAsync(list.SubTypeGeneration, read: true);
            ListBinaryType listBinaryType = GetListType(list, data, subData);

            if (data.MarkerType.HasValue)
            {
                fg.AppendLine($"frame.Position += frame.{nameof(MutagenFrame.MetaData)}.{nameof(MetaDataConstants.SubConstants)}.{nameof(MetaDataConstants.SubConstants.HeaderLength)} + contentLength; // Skip marker");
            }
            else if (listBinaryType == ListBinaryType.Trigger)
            {
                fg.AppendLine($"frame.Position += frame.{nameof(MutagenBinaryReadStream.MetaData)}.{nameof(MetaDataConstants.SubConstants)}.{nameof(IRecordConstants.HeaderLength)};");
            }

            bool threading = list.CustomData.TryGetValue(ThreadKey, out var t)
                && (bool)t;

            using (var args = new ArgsWrapper(fg,
                $"{Loqui.Generation.Utility.Await(isAsync)}{this.Namespace}List{(isAsync ? "Async" : null)}BinaryTranslation<{list.SubTypeGeneration.TypeName(getter: false)}>.Instance.ParseRepeatedItem",
                suffixLine: Loqui.Generation.Utility.ConfigAwait(isAsync)))
            {
                if (listBinaryType == ListBinaryType.Amount)
                {
                    args.Add($"frame: frame");
                    args.Add($"amount: {list.MaxValue.Value}");
                }
                else if (listBinaryType == ListBinaryType.SubTrigger)
                {
                    args.Add($"frame: frame");
                    args.Add($"triggeringRecord: {subData.TriggeringRecordSetAccessor}");
                }
                else if (listBinaryType == ListBinaryType.Trigger)
                {
                    args.Add($"frame: frame.SpawnWithLength(contentLength)");
                }
                else if (listBinaryType == ListBinaryType.Frame)
                {
                    args.Add($"frame: frame");
                }
                else
                {
                    throw new NotImplementedException();
                }
                if (threading)
                {
                    args.Add($"thread: true");
                }
                if (list.SubTypeGeneration is FormIDLinkType)
                {
                    args.Add($"masterReferences: masterReferences");
                }
                args.Add($"item: {itemAccessor.PropertyOrDirectAccess}");
                if (subTransl.DoErrorMasks)
                {
                    args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                }
                if (list.CustomData.TryGetValue("lengthLength", out object len))
                {
                    args.Add($"lengthLength: {len}");
                }
                else if (!list.MaxValue.HasValue
                    && list.SubTypeGeneration.GetFieldData().HasTrigger)
                {
                    if (list.SubTypeGeneration is MutagenLoquiType loqui)
                    {
                        switch (loqui.GetObjectType())
                        {
                            case ObjectType.Subrecord:
                                args.Add($"lengthLength: frame.{nameof(MutagenFrame.MetaData)}.{nameof(MetaDataConstants.SubConstants)}.{nameof(MetaDataConstants.SubConstants.LengthLength)}");
                                break;
                            case ObjectType.Group:
                                args.Add($"lengthLength: frame.{nameof(MutagenFrame.MetaData)}.{nameof(MetaDataConstants.GroupConstants)}.{nameof(MetaDataConstants.SubConstants.LengthLength)}");
                                break;
                            case ObjectType.Record:
                                args.Add($"lengthLength: frame.{nameof(MutagenFrame.MetaData)}.{nameof(MetaDataConstants.MajorConstants)}.{nameof(MetaDataConstants.SubConstants.LengthLength)}");
                                break;
                            case ObjectType.Mod:
                            default:
                                throw new ArgumentException();
                        }
                    }
                    else
                    {
                        args.Add($"lengthLength: frame.{nameof(MutagenFrame.MetaData)}.{nameof(MetaDataConstants.SubConstants)}.{nameof(MetaDataConstants.SubConstants.LengthLength)}");
                    }
                }
                if (subTransl.DoErrorMasks)
                {
                    args.Add($"errorMask: {errorMaskAccessor}");
                }
                var subGenTypes = subData.GenerationTypes.ToList();
                var subGen = this.Module.GetTypeGeneration(list.SubTypeGeneration.GetType());
                if (subGenTypes.Count <= 1 && subTransl.AllowDirectParse(
                    objGen,
                    typeGen: typeGen,
                    squashedRepeatedList: listBinaryType == ListBinaryType.Trigger))
                {
                    if (list.SubTypeGeneration is LoquiType loqui
                        && !loqui.CanStronglyType)
                    {
                        args.Add($"transl: {subTransl.GetTranslatorInstance(list.SubTypeGeneration, getter: false)}.Parse<{loqui.TypeName(getter: false)}>");
                    }
                    else
                    {
                        args.Add($"transl: {subTransl.GetTranslatorInstance(list.SubTypeGeneration, getter: false)}.Parse");
                    }
                }
                else
                {
                    args.Add((gen) =>
                    {
                        gen.AppendLine($"transl: {Loqui.Generation.Utility.Async(isAsync)}(MutagenFrame r{(subGenTypes.Count <= 1 ? string.Empty : ", RecordType header")}{(isAsync ? null : $", out {list.SubTypeGeneration.TypeName(getter: false)} listSubItem")}{(subTransl.DoErrorMasks ? ", ErrorMaskBuilder listErrMask" : null)}) =>");
                        using (new BraceWrapper(gen))
                        {
                            if (subGenTypes.Count <= 1)
                            {
                                subGen.GenerateCopyInRet(
                                    fg: gen,
                                    objGen: objGen,
                                    targetGen: list.SubTypeGeneration,
                                    typeGen: list.SubTypeGeneration,
                                    readerAccessor: "r",
                                    translationAccessor: "listTranslMask",
                                    retAccessor: "return ",
                                    outItemAccessor: new Accessor("listSubItem"),
                                    asyncMode: isAsync ? AsyncMode.Async : AsyncMode.Off,
                                    errorMaskAccessor: "listErrMask");
                            }
                            else
                            {
                                gen.AppendLine("switch (header.TypeInt)");
                                using (new BraceWrapper(gen))
                                {
                                    foreach (var item in subGenTypes)
                                    {
                                        foreach (var trigger in item.Key)
                                        {
                                            gen.AppendLine($"case 0x{trigger.TypeInt.ToString("X")}: // {trigger.Type}");
                                        }
                                        LoquiType targetLoqui = list.SubTypeGeneration as LoquiType;
                                        LoquiType specificLoqui = item.Value as LoquiType;
                                        using (new DepthWrapper(gen))
                                        {
                                            subGen.GenerateCopyInRet(
                                                fg: gen,
                                                objGen: objGen,
                                                targetGen: list.SubTypeGeneration,
                                                typeGen: item.Value,
                                                readerAccessor: "r",
                                                translationAccessor: "listTranslMask",
                                                retAccessor: "return ",
                                                outItemAccessor: new Accessor("listSubItem"),
                                                asyncMode: AsyncMode.Async,
                                                errorMaskAccessor: $"listErrMask");
                                        }
                                    }
                                    gen.AppendLine("default:");
                                    using (new DepthWrapper(gen))
                                    {
                                        gen.AppendLine("throw new NotImplementedException();");
                                    }
                                }
                            }
                        }
                    });
                }
            }
        }

        public override void GenerateCopyInRet(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration targetGen,
            TypeGeneration typeGen,
            Accessor nodeAccessor,
            AsyncMode asyncMode,
            Accessor retAccessor,
            Accessor outItemAccessor,
            Accessor errorMaskAccessor,
            Accessor translationAccessor)
        {
            throw new NotImplementedException();
        }

        public override void GenerateWrapperFields(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            Accessor dataAccessor,
            int currentPosition,
            DataType dataType = null)
        {
            ListType list = typeGen as ListType;
            var data = list.GetFieldData();
            if (list.MaxValue.HasValue)
            {
                var posStr = $"_{dataType.GetFieldData().RecordType}Location.Value + {currentPosition}";
                if (list.SubTypeGeneration is EnumType e)
                {
                    fg.AppendLine($"public IReadOnlyList<{list.SubTypeGeneration.TypeName(getter: true)}> {typeGen.Name} => BinaryWrapperNumberedList.FactoryForEnum<{list.SubTypeGeneration.TypeName(getter: true)}>(_{dataType.GetFieldData().RecordType}Location.HasValue ? {dataAccessor}.Slice({posStr}) : default, amount: {list.MaxValue.Value}, enumLength: {e.ByteLength});");
                }
                else if (list.SubTypeGeneration is LoquiType loqui)
                {
                    string recConverter = "null";
                    if (data?.RecordTypeConverter != null
                        && data.RecordTypeConverter.FromConversions.Count > 0)
                    {
                        recConverter = $"recordTypeConverter: {objGen.RegistrationName}.{typeGen.Name}Converter";
                    }
                    var gen = this.Module.GetTypeGeneration(loqui.GetType());
                    fg.AppendLine($"public IReadOnlyList<{list.SubTypeGeneration.TypeName(getter: true)}> {typeGen.Name} => BinaryWrapperNumberedList.FactoryForLoqui<{list.SubTypeGeneration.TypeName(getter: true)}>(_{dataType.GetFieldData().RecordType}Location.HasValue ? {dataAccessor}.Slice({posStr}) : default, amount: {list.MaxValue.Value}, length: {gen.ExpectedLength(objGen, loqui)}, _package, {recConverter}, {this.Module.BinaryWrapperClassName(loqui.TargetObjectGeneration)}.{loqui.TargetObjectGeneration.Name}Factory);");
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (list.SubTypeGeneration is LoquiType loqui)
            {
                var typeName = this.Module.BinaryWrapperClassName(loqui.TargetObjectGeneration);
                fg.AppendLine($"public IReadOnly{(list.HasBeenSet ? "Set" : null)}List<{loqui.TypeName(getter: true)}> {typeGen.Name} {{ get; private set; }} = EmptySetList<{typeName}>.Instance;");
            }
            else
            {
                fg.AppendLine($"public IReadOnly{(list.HasBeenSet ? "Set" : null)}List<{list.SubTypeGeneration.TypeName(getter: true)}> {typeGen.Name} {{ get; private set; }} = EmptySetList<{list.SubTypeGeneration.TypeName(getter: true)}>.Instance;");
            }
        }

        public override int? ExpectedLength(ObjectGeneration objGen, TypeGeneration typeGen)
        {
            ListType list = typeGen as ListType;
            if (list.MaxValue.HasValue)
            {
                if (list.HasBeenSet)
                {
                    throw new NotImplementedException();
                }
                else if (list.SubTypeGeneration is EnumType e)
                {
                    return list.MaxValue.Value * e.ByteLength;
                }
                else if (list.SubTypeGeneration is LoquiType loqui
                    && this.Module.TryGetTypeGeneration(loqui.GetType(), out var loquiGen))
                {
                    return list.MaxValue.Value * loquiGen.GetPassedAmount(objGen, loqui);
                }
                throw new NotImplementedException();
            }
            return null;
        }

        public override async Task GenerateWrapperRecordTypeParse(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            Accessor locationAccessor,
            Accessor packageAccessor,
            Accessor converterAccessor)
        {
            ListType list = typeGen as ListType;
            var data = list.GetFieldData();
            if (data.MarkerType.HasValue)
            {
                fg.AppendLine($"stream.Position += {packageAccessor}.Meta.SubConstants.HeaderLength; // Skip marker");
            }
            var subData = list.SubTypeGeneration.GetFieldData();
            var subGenTypes = subData.GenerationTypes.ToList();
            ListBinaryType listBinaryType = GetListType(list, data, subData);
            var subGen = this.Module.GetTypeGeneration(list.SubTypeGeneration.GetType());
            string typeName;
            LoquiType loqui = list.SubTypeGeneration as LoquiType;
            if (loqui != null)
            {
                typeName = this.Module.BinaryWrapperClassName(loqui.TargetObjectGeneration);
            }
            else
            {
                typeName = list.SubTypeGeneration.TypeName(getter: true);
            }
            switch (listBinaryType)
            {
                case ListBinaryType.SubTrigger:
                    if (loqui != null)
                    {
                        if (loqui.TargetObjectGeneration.IsTypelessStruct())
                        {
                            using (var args = new ArgsWrapper(fg,
                                $"this.{typeGen.Name} = {nameof(UtilityTranslation)}.{nameof(UtilityTranslation.ParseRepeatedTypelessSubrecord)}<{typeName}>"))
                            {
                                args.AddPassArg("stream");
                                args.Add("package: _package");
                                args.Add($"recordTypeConverter: {converterAccessor}");
                                args.Add($"trigger: {subData.TriggeringRecordSetAccessor}");
                                if (subGenTypes.Count <= 1)
                                {
                                    args.Add($"factory:  {this.Module.BinaryWrapperClassName(loqui.TargetObjectGeneration)}.{loqui.TargetObjectGeneration.Name}Factory");
                                }
                                else
                                {
                                    args.Add((subFg) =>
                                    {
                                        subFg.AppendLine("factory: (s, r, p, recConv) =>");
                                        using (new BraceWrapper(subFg))
                                        {
                                            subFg.AppendLine("switch (r.TypeInt)");
                                            using (new BraceWrapper(subFg))
                                            {
                                                foreach (var item in subGenTypes)
                                                {
                                                    foreach (var trigger in item.Key)
                                                    {
                                                        subFg.AppendLine($"case 0x{trigger.TypeInt.ToString("X")}: // {trigger.Type}");
                                                    }
                                                    using (new DepthWrapper(subFg))
                                                    {
                                                        LoquiType specificLoqui = item.Value as LoquiType;
                                                        subFg.AppendLine($"return {this.Module.BinaryWrapperClassName(specificLoqui.TargetObjectGeneration)}.{specificLoqui.TargetObjectGeneration.Name}Factory(s, p);");
                                                    }
                                                }
                                                subFg.AppendLine("default:");
                                                using (new DepthWrapper(subFg))
                                                {
                                                    subFg.AppendLine("throw new NotImplementedException();");
                                                }
                                            }
                                        }
                                    });
                                }
                            }
                        }
                        else
                        {
                            using (var args = new ArgsWrapper(fg,
                                $"this.{typeGen.Name} = BinaryWrapperSetList<{typeName}>.FactoryByArray"))
                            {
                                args.Add($"mem: stream.RemainingMemory");
                                args.Add($"package: _package");
                                args.Add($"recordTypeConverter: {converterAccessor}");
                                args.Add($"getter: (s, p, recConv) => {typeName}.{loqui.TargetObjectGeneration.Name}Factory(new {nameof(BinaryMemoryReadStream)}(s), p, recConv)");
                                args.Add(subFg =>
                                {
                                    using (var subArgs = new FunctionWrapper(subFg,
                                        $"locs: UtilityTranslation.ParseSubrecordLocations"))
                                    {
                                        subArgs.AddPassArg("stream");
                                        subArgs.Add("meta: _package.Meta");
                                        subArgs.Add("trigger: type");
                                        subArgs.Add("skipHeader: false");
                                    }
                                });
                            }
                        }
                    }
                    else
                    {
                        using (var args = new ArgsWrapper(fg,
                            $"this.{typeGen.Name} = BinaryWrapperSetList<{typeName}>.FactoryByArray"))
                        {
                            args.Add($"mem: stream.RemainingMemory");
                            args.Add($"package: _package");
                            args.Add($"getter: (s, p) => {subGen.GenerateForTypicalWrapper(objGen, list.SubTypeGeneration, "s", "p")}");
                            args.Add(subFg =>
                            {
                                using (var subArgs = new FunctionWrapper(subFg,
                                    $"locs: UtilityTranslation.ParseSubrecordLocations"))
                                {
                                    subArgs.AddPassArg("stream");
                                    subArgs.Add("meta: _package.Meta");
                                    subArgs.Add("trigger: type");
                                    subArgs.Add("skipHeader: true");
                                }
                            });
                        }
                    }
                    break;
                case ListBinaryType.Trigger:
                    fg.AppendLine("var subMeta = _package.Meta.ReadSubRecord(stream);");
                    fg.AppendLine("var subLen = subMeta.RecordLength;");
                    using (var args = new ArgsWrapper(fg,
                        $"this.{typeGen.Name} = BinaryWrapperSetList<{typeName}>.FactoryByStartIndex"))
                    {
                        args.Add($"mem: stream.RemainingMemory.Slice(0, subLen)");
                        args.Add($"package: _package");
                        args.Add($"itemLength: {subGen.ExpectedLength(objGen, list.SubTypeGeneration)}");
                        if (subGenTypes.Count <= 1)
                        {
                            args.Add($"getter: (s, p) => {subGen.GenerateForTypicalWrapper(objGen, list.SubTypeGeneration, "s", "p")}");
                        }
                        else
                        {
                            args.Add((subFg) =>
                            {
                                subFg.AppendLine("getter: (s, r, p) =>");
                                using (new BraceWrapper(subFg))
                                {
                                    subFg.AppendLine("switch (r.TypeInt)");
                                    using (new BraceWrapper(subFg))
                                    {
                                        foreach (var item in subGenTypes)
                                        {
                                            foreach (var trigger in item.Key)
                                            {
                                                subFg.AppendLine($"case 0x{trigger.TypeInt.ToString("X")}: // {trigger.Type}");
                                            }
                                            using (new DepthWrapper(subFg))
                                            {
                                                LoquiType specificLoqui = item.Value as LoquiType;
                                                subFg.AppendLine($"return {subGen.GenerateForTypicalWrapper(objGen, specificLoqui, "s", "p")}");
                                            }
                                        }
                                        subFg.AppendLine("default:");
                                        using (new DepthWrapper(subFg))
                                        {
                                            subFg.AppendLine("throw new NotImplementedException();");
                                        }
                                    }
                                }
                            });
                        }
                    }
                    fg.AppendLine("stream.Position += subLen;");
                    break;
                case ListBinaryType.Amount:
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
