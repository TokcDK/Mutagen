using Loqui.Generation;
using Mutagen.Bethesda.Generation.Fields;
using Mutagen.Bethesda.Generation.Modules.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;

namespace Mutagen.Bethesda.Generation.Modules.Plugin;

public class FormKeyBinaryTranslationGeneration : PrimitiveBinaryTranslationGeneration<FormKey>
{
    public override bool NeedsGenerics => false;

    public FormKeyBinaryTranslationGeneration()
        : base(expectedLen: 4)
    {
        this.PreferDirectTranslation = false;
    }

    public override async Task GenerateWrapperFields(
        StructuredStringBuilder sb,
        ObjectGeneration objGen, 
        TypeGeneration typeGen,
        Accessor structDataAccessor,  
        Accessor recordDataAccessor, 
        int? currentPosition,
        string passedLengthAccessor,
        DataType dataType)
    {
        var data = typeGen.CustomData[Constants.DataKey] as MutagenFieldData;
        if (data.RecordType.HasValue
            || await this.ExpectedLength(objGen, typeGen) == null)
        {
            return;
            throw new NotImplementedException();
        }
        var posStr = dataType == null ? $"{passedLengthAccessor}" : $"_{dataType.GetFieldData().RecordType}Location + {passedLengthAccessor}";
        sb.AppendLine($"public {typeGen.TypeName(getter: true)} {typeGen.Name} => FormKeyBinaryTranslation.Instance.Parse({structDataAccessor}.Span.Slice({posStr}, {(await this.ExpectedLength(objGen, typeGen)).Value}), this._package.{nameof(BinaryOverlayFactoryPackage.MetaData)}.{nameof(ParsingBundle.MasterReferences)}!);");
    }

    public override void GenerateCopyInRet(
        StructuredStringBuilder sb,
        ObjectGeneration objGen,
        TypeGeneration targetGen,
        TypeGeneration typeGen,
        Accessor nodeAccessor,
        AsyncMode asyncMode,
        Accessor retAccessor,
        Accessor outItemAccessor,
        Accessor errorMaskAccessor,
        Accessor translationMaskAccessor,
        Accessor converterAccessor,
        bool inline)
    {
        if (inline) throw new NotImplementedException();
        if (asyncMode != AsyncMode.Off) throw new NotImplementedException();
        var data = typeGen.GetFieldData();
        if (data.RecordType.HasValue)
        {
            sb.AppendLine("r.Position += Constants.SUBRECORD_LENGTH;");
        }
        using (var args = sb.Call(
                   $"{retAccessor}{this.NamespacePrefix}{this.Typename(typeGen)}BinaryTranslation.Instance.Parse"))
        {
            args.Add(nodeAccessor.Access);
            if (this.DoErrorMasks)
            {
                args.Add($"errorMask: {errorMaskAccessor}");
            }
            args.Add($"translationMask: {translationMaskAccessor}");
        }
    }
}