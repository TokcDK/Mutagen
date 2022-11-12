/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectCloakArchetype :
        MagicEffectArchetype,
        IEquatable<IMagicEffectCloakArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectCloakArchetype>,
        IMagicEffectCloakArchetypeInternal
    {

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectCloakArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectCloakArchetypeGetter rhs) return false;
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IMagicEffectCloakArchetypeGetter? obj)
        {
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            MagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Type,
                TItem AssociationKey,
                TItem ActorValue)
            : base(
                Type: Type,
                AssociationKey: AssociationKey,
                ActorValue: ActorValue)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectCloakArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(MagicEffectCloakArchetype.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, MagicEffectCloakArchetype.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(MagicEffectCloakArchetype.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            MagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectCloakArchetype_FieldIndex enu = (MagicEffectCloakArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectCloakArchetype_FieldIndex enu = (MagicEffectCloakArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectCloakArchetype_FieldIndex enu = (MagicEffectCloakArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            MagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectCloakArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectCloakArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static MagicEffectCloakArchetype CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new MagicEffectCloakArchetype();
            ((MagicEffectCloakArchetypeSetterCommon)((IMagicEffectCloakArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectCloakArchetype item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((MagicEffectCloakArchetypeSetterCommon)((IMagicEffectCloakArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectCloakArchetype GetNew()
        {
            return new MagicEffectCloakArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectCloakArchetype :
        ILoquiObjectSetter<IMagicEffectCloakArchetypeInternal>,
        IMagicEffectArchetypeInternal,
        IMagicEffectCloakArchetypeGetter
    {
    }

    public partial interface IMagicEffectCloakArchetypeInternal :
        IMagicEffectArchetypeInternal,
        IMagicEffectCloakArchetype,
        IMagicEffectCloakArchetypeGetter
    {
    }

    public partial interface IMagicEffectCloakArchetypeGetter :
        IMagicEffectArchetypeGetter,
        IBinaryItem,
        ILoquiObject<IMagicEffectCloakArchetypeGetter>
    {
        static new ILoquiRegistration StaticRegistration => MagicEffectCloakArchetype_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectCloakArchetypeMixIn
    {
        public static void Clear(this IMagicEffectCloakArchetypeInternal item)
        {
            ((MagicEffectCloakArchetypeSetterCommon)((IMagicEffectCloakArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectCloakArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectCloakArchetypeGetter item,
            IMagicEffectCloakArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IMagicEffectCloakArchetypeGetter item,
            string? name = null,
            MagicEffectCloakArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IMagicEffectCloakArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectCloakArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectCloakArchetypeGetter item,
            IMagicEffectCloakArchetypeGetter rhs,
            MagicEffectCloakArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectCloakArchetypeInternal lhs,
            IMagicEffectCloakArchetypeGetter rhs,
            out MagicEffectCloakArchetype.ErrorMask errorMask,
            MagicEffectCloakArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectCloakArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectCloakArchetypeInternal lhs,
            IMagicEffectCloakArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectCloakArchetype DeepCopy(
            this IMagicEffectCloakArchetypeGetter item,
            MagicEffectCloakArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectCloakArchetype DeepCopy(
            this IMagicEffectCloakArchetypeGetter item,
            out MagicEffectCloakArchetype.ErrorMask errorMask,
            MagicEffectCloakArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectCloakArchetype DeepCopy(
            this IMagicEffectCloakArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectCloakArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((MagicEffectCloakArchetypeSetterCommon)((IMagicEffectCloakArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum MagicEffectCloakArchetype_FieldIndex
    {
        Type = 0,
        AssociationKey = 1,
        ActorValue = 2,
    }
    #endregion

    #region Registration
    internal partial class MagicEffectCloakArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectCloakArchetype_Registration Instance = new MagicEffectCloakArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 120,
            version: 0);

        public const string GUID = "bcdbf09b-cdf0-4674-a8a7-4569bae2271e";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(MagicEffectCloakArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectCloakArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectCloakArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectCloakArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectCloakArchetype);

        public static readonly Type? InternalSetterType = typeof(IMagicEffectCloakArchetypeInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectCloakArchetype";

        public const string Name = "MagicEffectCloakArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectCloakArchetypeBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class MagicEffectCloakArchetypeSetterCommon : MagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectCloakArchetypeSetterCommon Instance = new MagicEffectCloakArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectCloakArchetypeInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IMagicEffectArchetypeInternal item)
        {
            Clear(item: (IMagicEffectCloakArchetypeInternal)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectCloakArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectCloakArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: MagicEffectCloakArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IMagicEffectArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (MagicEffectCloakArchetype)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class MagicEffectCloakArchetypeCommon : MagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectCloakArchetypeCommon Instance = new MagicEffectCloakArchetypeCommon();

        public MagicEffectCloakArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectCloakArchetypeGetter item,
            IMagicEffectCloakArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectCloakArchetype.Mask<bool>(false);
            ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectCloakArchetypeGetter item,
            IMagicEffectCloakArchetypeGetter rhs,
            MagicEffectCloakArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IMagicEffectCloakArchetypeGetter item,
            string? name = null,
            MagicEffectCloakArchetype.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IMagicEffectCloakArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectCloakArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"MagicEffectCloakArchetype =>");
            }
            else
            {
                sb.AppendLine($"{name} (MagicEffectCloakArchetype) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IMagicEffectCloakArchetypeGetter item,
            StructuredStringBuilder sb,
            MagicEffectCloakArchetype.Mask<bool>? printMask = null)
        {
            MagicEffectArchetypeCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static MagicEffectCloakArchetype_FieldIndex ConvertFieldIndex(MagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case MagicEffectArchetype_FieldIndex.Type:
                    return (MagicEffectCloakArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.AssociationKey:
                    return (MagicEffectCloakArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectCloakArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectCloakArchetypeGetter? lhs,
            IMagicEffectCloakArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IMagicEffectArchetypeGetter)lhs, (IMagicEffectArchetypeGetter)rhs, equalsMask)) return false;
            return true;
        }
        
        public override bool Equals(
            IMagicEffectArchetypeGetter? lhs,
            IMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IMagicEffectCloakArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectCloakArchetypeGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IMagicEffectCloakArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectCloakArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectCloakArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IMagicEffectCloakArchetypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class MagicEffectCloakArchetypeSetterTranslationCommon : MagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectCloakArchetypeSetterTranslationCommon Instance = new MagicEffectCloakArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectCloakArchetypeInternal item,
            IMagicEffectCloakArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                item,
                rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public void DeepCopyIn(
            IMagicEffectCloakArchetype item,
            IMagicEffectCloakArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IMagicEffectArchetype)item,
                (IMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetypeInternal item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectCloakArchetypeInternal)item,
                rhs: (IMagicEffectCloakArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetype item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectCloakArchetype)item,
                rhs: (IMagicEffectCloakArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectCloakArchetype DeepCopy(
            IMagicEffectCloakArchetypeGetter item,
            MagicEffectCloakArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectCloakArchetype ret = (MagicEffectCloakArchetype)((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectCloakArchetype DeepCopy(
            IMagicEffectCloakArchetypeGetter item,
            out MagicEffectCloakArchetype.ErrorMask errorMask,
            MagicEffectCloakArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectCloakArchetype ret = (MagicEffectCloakArchetype)((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectCloakArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectCloakArchetype DeepCopy(
            IMagicEffectCloakArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectCloakArchetype ret = (MagicEffectCloakArchetype)((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectCloakArchetypeSetterTranslationCommon)((IMagicEffectCloakArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectCloakArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectCloakArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectCloakArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectCloakArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectCloakArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectCloakArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectCloakArchetypeBinaryWriteTranslation :
        MagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly MagicEffectCloakArchetypeBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IMagicEffectCloakArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            MagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IMagicEffectCloakArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IMagicEffectArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IMagicEffectCloakArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class MagicEffectCloakArchetypeBinaryCreateTranslation : MagicEffectArchetypeBinaryCreateTranslation
    {
        public new static readonly MagicEffectCloakArchetypeBinaryCreateTranslation Instance = new MagicEffectCloakArchetypeBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectCloakArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class MagicEffectCloakArchetypeBinaryOverlay :
        MagicEffectArchetypeBinaryOverlay,
        IMagicEffectCloakArchetypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectCloakArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectCloakArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectCloakArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectCloakArchetypeSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectCloakArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectCloakArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected MagicEffectCloakArchetypeBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IMagicEffectCloakArchetypeGetter MagicEffectCloakArchetypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new MagicEffectCloakArchetypeBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IMagicEffectCloakArchetypeGetter MagicEffectCloakArchetypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return MagicEffectCloakArchetypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectCloakArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectCloakArchetypeGetter rhs) return false;
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IMagicEffectCloakArchetypeGetter? obj)
        {
            return ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((MagicEffectCloakArchetypeCommon)((IMagicEffectCloakArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

