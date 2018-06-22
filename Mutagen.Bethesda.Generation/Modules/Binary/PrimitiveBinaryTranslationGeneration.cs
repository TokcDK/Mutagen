﻿using Loqui;
using Loqui.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda.Generation
{
    public class PrimitiveBinaryTranslationGeneration<T> : BinaryTranslationGeneration
    {
        private string typeName;
        protected bool? nullable;
        public bool Nullable => nullable ?? false || typeof(T).GetName().EndsWith("?");

        public override string GetTranslatorInstance(TypeGeneration typeGen)
        {
            return $"{typeName}BinaryTranslation.Instance";
        }

        public PrimitiveBinaryTranslationGeneration(string typeName = null, bool? nullable = null)
        {
            this.nullable = nullable;
            this.typeName = typeName ?? typeof(T).GetName().Replace("?", string.Empty);
        }

        protected virtual string ItemWriteAccess(Accessor itemAccessor)
        {
            return itemAccessor.PropertyOrDirectAccess;
        }

        public virtual string Typename(TypeGeneration typeGen) => typeName;

        public override void GenerateWrite(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string writerAccessor,
            Accessor itemAccessor,
            string maskAccessor)
        {
            var data = typeGen.CustomData[Constants.DATA_KEY] as MutagenFieldData;
            using (var args = new ArgsWrapper(fg,
                $"{this.Namespace}{this.Typename(typeGen)}BinaryTranslation.Instance.Write"))
            {
                args.Add($"writer: {writerAccessor}");
                args.Add($"item: {ItemWriteAccess(itemAccessor)}");
                if (typeGen.HasIndex)
                {
                    args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                }
                args.Add($"errorMask: {maskAccessor}");
                if (data.RecordType.HasValue)
                {
                    args.Add($"header: recordTypeConverter.ConvertToCustom({objGen.RecordTypeHeaderName(data.RecordType.Value)})");
                    args.Add($"nullable: {(data.Optional ? "true" : "false")}");
                }
                foreach (var arg in AdditionWriteParameters(
                    fg: fg,
                    objGen: objGen,
                    typeGen: typeGen,
                    writerAccessor: writerAccessor,
                    itemAccessor: itemAccessor,
                    maskAccessor: maskAccessor))
                {
                    args.Add(arg);
                }
            }
        }

        protected virtual IEnumerable<string> AdditionWriteParameters(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string writerAccessor,
            Accessor itemAccessor,
            string maskAccessor)
        {
            yield break;
        }

        public override void GenerateCopyIn(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string nodeAccessor,
            Accessor itemAccessor,
            string maskAccessor)
        {
            var prim = typeGen as PrimitiveType;
            var data = typeGen.CustomData[Constants.DATA_KEY] as MutagenFieldData;
            if (data.HasTrigger)
            {
                fg.AppendLine($"{nodeAccessor}.Position += Constants.SUBRECORD_LENGTH;");
            }
            ArgsWrapper args;
            if (typeGen.PrefersProperty)
            {
                args = new ArgsWrapper(fg, $"{this.Namespace}{this.Typename(typeGen)}BinaryTranslation.Instance.ParseInto");
            }
            else
            {
                args = new ArgsWrapper(fg, $"var {typeGen.Name}tryGet = {this.Namespace}{this.Typename(typeGen)}BinaryTranslation.Instance.Parse");
            }
            using (args)
            {
                if (data.HasTrigger)
                {
                    args.Add($"frame: {nodeAccessor}.SpawnWithLength(contentLength)");
                }
                else
                {
                    args.Add($"frame: {nodeAccessor}.Spawn(snapToFinalPosition: false)");
                }
                if (itemAccessor.PropertyAccess != null)
                {
                    args.Add($"item: {itemAccessor.PropertyAccess}");
                }
                if (typeGen.HasIndex)
                {
                    args.Add($"fieldIndex: (int){typeGen.IndexEnumName}");
                    args.Add($"errorMask: {maskAccessor}");
                }
                else
                {
                    throw new NotImplementedException();
                }
                foreach (var arg in AdditionCopyInParameters(
                    fg: fg,
                    objGen: objGen,
                    typeGen: typeGen,
                    nodeAccessor: nodeAccessor,
                    itemAccessor: itemAccessor,
                    maskAccessor: maskAccessor))
                {
                    args.Add(arg);
                }
            }
            TranslationGenerationSnippets.DirectTryGetSetting(fg, itemAccessor, typeGen);
        }

        protected virtual IEnumerable<string> AdditionCopyInParameters(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string nodeAccessor,
            Accessor itemAccessor,
            string maskAccessor)
        {
            yield break;
        }

        public override void GenerateCopyInRet(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration targetGen,
            TypeGeneration typeGen,
            string nodeAccessor,
            bool squashedRepeatedList,
            string retAccessor,
            Accessor outItemAccessor,
            string maskAccessor)
        {
            if (typeGen.TryGetFieldData(out var data)
                && data.RecordType.HasValue)
            {
                fg.AppendLine("r.Position += Constants.SUBRECORD_LENGTH;");
            }
            using (var args = new ArgsWrapper(fg,
                $"{retAccessor}{this.Namespace}{this.Typename(typeGen)}BinaryTranslation.Instance.Parse"))
            {
                args.Add(nodeAccessor);
                args.Add($"errorMask: {maskAccessor}");
                foreach (var arg in AdditionCopyInRetParameters(
                    fg: fg,
                    objGen: objGen,
                    typeGen: typeGen,
                    nodeAccessor: nodeAccessor,
                    retAccessor: retAccessor,
                    outItemAccessor: outItemAccessor,
                    maskAccessor: maskAccessor))
                {
                    args.Add(arg);
                }
            }
        }

        protected virtual IEnumerable<string> AdditionCopyInRetParameters(
            FileGeneration fg,
            ObjectGeneration objGen,
            TypeGeneration typeGen,
            string nodeAccessor,
            string retAccessor,
            Accessor outItemAccessor,
            string maskAccessor)
        {
            yield break;
        }
    }
}
