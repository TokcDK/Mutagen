/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectVampireArchetype :
        MagicEffectArchetype,
        IMagicEffectVampireArchetypeInternal,
        ILoquiObjectSetter<MagicEffectVampireArchetype>,
        IEquatable<IMagicEffectVampireArchetypeGetter>
    {

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            MagicEffectVampireArchetypeMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IMagicEffectVampireArchetypeGetter rhs)) return false;
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IMagicEffectVampireArchetypeGetter? obj)
        {
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            MagicEffectArchetype.Mask<TItem>,
            IMask<TItem>,
            IEquatable<Mask<TItem>>
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
                var ret = new MagicEffectVampireArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(MagicEffectVampireArchetype.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, MagicEffectVampireArchetype.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(MagicEffectVampireArchetype.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                }
                fg.AppendLine("]");
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
                MagicEffectVampireArchetype_FieldIndex enu = (MagicEffectVampireArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectVampireArchetype_FieldIndex enu = (MagicEffectVampireArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectVampireArchetype_FieldIndex enu = (MagicEffectVampireArchetype_FieldIndex)index;
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
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public override void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected override void ToString_FillInternal(FileGeneration fg)
            {
                base.ToString_FillInternal(fg);
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
        protected override object BinaryWriteTranslator => MagicEffectVampireArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectVampireArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static MagicEffectVampireArchetype CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new MagicEffectVampireArchetype();
            ((MagicEffectVampireArchetypeSetterCommon)((IMagicEffectVampireArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectVampireArchetype item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((MagicEffectVampireArchetypeSetterCommon)((IMagicEffectVampireArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectVampireArchetype GetNew()
        {
            return new MagicEffectVampireArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectVampireArchetype :
        IMagicEffectVampireArchetypeGetter,
        IMagicEffectArchetype,
        ILoquiObjectSetter<IMagicEffectVampireArchetypeInternal>
    {
    }

    public partial interface IMagicEffectVampireArchetypeInternal :
        IMagicEffectArchetypeInternal,
        IMagicEffectVampireArchetype,
        IMagicEffectVampireArchetypeGetter
    {
    }

    public partial interface IMagicEffectVampireArchetypeGetter :
        IMagicEffectArchetypeGetter,
        ILoquiObject<IMagicEffectVampireArchetypeGetter>,
        IBinaryItem
    {
        static new ILoquiRegistration Registration => MagicEffectVampireArchetype_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectVampireArchetypeMixIn
    {
        public static void Clear(this IMagicEffectVampireArchetypeInternal item)
        {
            ((MagicEffectVampireArchetypeSetterCommon)((IMagicEffectVampireArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectVampireArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectVampireArchetypeGetter item,
            IMagicEffectVampireArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IMagicEffectVampireArchetypeGetter item,
            string? name = null,
            MagicEffectVampireArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IMagicEffectVampireArchetypeGetter item,
            FileGeneration fg,
            string? name = null,
            MagicEffectVampireArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectVampireArchetypeGetter item,
            IMagicEffectVampireArchetypeGetter rhs)
        {
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IMagicEffectVampireArchetypeInternal lhs,
            IMagicEffectVampireArchetypeGetter rhs,
            out MagicEffectVampireArchetype.ErrorMask errorMask,
            MagicEffectVampireArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectVampireArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectVampireArchetypeInternal lhs,
            IMagicEffectVampireArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectVampireArchetype DeepCopy(
            this IMagicEffectVampireArchetypeGetter item,
            MagicEffectVampireArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectVampireArchetype DeepCopy(
            this IMagicEffectVampireArchetypeGetter item,
            out MagicEffectVampireArchetype.ErrorMask errorMask,
            MagicEffectVampireArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectVampireArchetype DeepCopy(
            this IMagicEffectVampireArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectVampireArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectVampireArchetypeSetterCommon)((IMagicEffectVampireArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum MagicEffectVampireArchetype_FieldIndex
    {
        Type = 0,
        AssociationKey = 1,
        ActorValue = 2,
    }
    #endregion

    #region Registration
    public partial class MagicEffectVampireArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectVampireArchetype_Registration Instance = new MagicEffectVampireArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 127,
            version: 0);

        public const string GUID = "39e7d9cb-f468-4b96-a58a-5c5b749a1c40";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(MagicEffectVampireArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectVampireArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectVampireArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectVampireArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectVampireArchetype);

        public static readonly Type? InternalSetterType = typeof(IMagicEffectVampireArchetypeInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectVampireArchetype";

        public const string Name = "MagicEffectVampireArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectVampireArchetypeBinaryWriteTranslation);
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
    public partial class MagicEffectVampireArchetypeSetterCommon : MagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectVampireArchetypeSetterCommon Instance = new MagicEffectVampireArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectVampireArchetypeInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IMagicEffectArchetypeInternal item)
        {
            Clear(item: (IMagicEffectVampireArchetypeInternal)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectVampireArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectVampireArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: MagicEffectVampireArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IMagicEffectArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (MagicEffectVampireArchetype)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class MagicEffectVampireArchetypeCommon : MagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectVampireArchetypeCommon Instance = new MagicEffectVampireArchetypeCommon();

        public MagicEffectVampireArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectVampireArchetypeGetter item,
            IMagicEffectVampireArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectVampireArchetype.Mask<bool>(false);
            ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectVampireArchetypeGetter item,
            IMagicEffectVampireArchetypeGetter rhs,
            MagicEffectVampireArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IMagicEffectVampireArchetypeGetter item,
            string? name = null,
            MagicEffectVampireArchetype.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IMagicEffectVampireArchetypeGetter item,
            FileGeneration fg,
            string? name = null,
            MagicEffectVampireArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"MagicEffectVampireArchetype =>");
            }
            else
            {
                fg.AppendLine($"{name} (MagicEffectVampireArchetype) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IMagicEffectVampireArchetypeGetter item,
            FileGeneration fg,
            MagicEffectVampireArchetype.Mask<bool>? printMask = null)
        {
            MagicEffectArchetypeCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
        }
        
        public static MagicEffectVampireArchetype_FieldIndex ConvertFieldIndex(MagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case MagicEffectArchetype_FieldIndex.Type:
                    return (MagicEffectVampireArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.AssociationKey:
                    return (MagicEffectVampireArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectVampireArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectVampireArchetypeGetter? lhs,
            IMagicEffectVampireArchetypeGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IMagicEffectArchetypeGetter)lhs, (IMagicEffectArchetypeGetter)rhs)) return false;
            return true;
        }
        
        public override bool Equals(
            IMagicEffectArchetypeGetter? lhs,
            IMagicEffectArchetypeGetter? rhs)
        {
            return Equals(
                lhs: (IMagicEffectVampireArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectVampireArchetypeGetter);
        }
        
        public virtual int GetHashCode(IMagicEffectVampireArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectVampireArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectVampireArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IMagicEffectVampireArchetypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class MagicEffectVampireArchetypeSetterTranslationCommon : MagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectVampireArchetypeSetterTranslationCommon Instance = new MagicEffectVampireArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectVampireArchetypeInternal item,
            IMagicEffectVampireArchetypeGetter rhs,
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
            IMagicEffectVampireArchetype item,
            IMagicEffectVampireArchetypeGetter rhs,
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
                item: (IMagicEffectVampireArchetypeInternal)item,
                rhs: (IMagicEffectVampireArchetypeGetter)rhs,
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
                item: (IMagicEffectVampireArchetype)item,
                rhs: (IMagicEffectVampireArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectVampireArchetype DeepCopy(
            IMagicEffectVampireArchetypeGetter item,
            MagicEffectVampireArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectVampireArchetype ret = (MagicEffectVampireArchetype)((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectVampireArchetype DeepCopy(
            IMagicEffectVampireArchetypeGetter item,
            out MagicEffectVampireArchetype.ErrorMask errorMask,
            MagicEffectVampireArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectVampireArchetype ret = (MagicEffectVampireArchetype)((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectVampireArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectVampireArchetype DeepCopy(
            IMagicEffectVampireArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectVampireArchetype ret = (MagicEffectVampireArchetype)((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectVampireArchetypeSetterTranslationCommon)((IMagicEffectVampireArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class MagicEffectVampireArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectVampireArchetype_Registration.Instance;
        public new static MagicEffectVampireArchetype_Registration Registration => MagicEffectVampireArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectVampireArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectVampireArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectVampireArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class MagicEffectVampireArchetypeBinaryWriteTranslation :
        MagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static MagicEffectVampireArchetypeBinaryWriteTranslation Instance = new MagicEffectVampireArchetypeBinaryWriteTranslation();

        public void Write(
            MutagenWriter writer,
            IMagicEffectVampireArchetypeGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            MagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IMagicEffectVampireArchetypeGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IMagicEffectArchetypeGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IMagicEffectVampireArchetypeGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class MagicEffectVampireArchetypeBinaryCreateTranslation : MagicEffectArchetypeBinaryCreateTranslation
    {
        public new readonly static MagicEffectVampireArchetypeBinaryCreateTranslation Instance = new MagicEffectVampireArchetypeBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectVampireArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class MagicEffectVampireArchetypeBinaryOverlay :
        MagicEffectArchetypeBinaryOverlay,
        IMagicEffectVampireArchetypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectVampireArchetype_Registration.Instance;
        public new static MagicEffectVampireArchetype_Registration Registration => MagicEffectVampireArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectVampireArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectVampireArchetypeSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectVampireArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectVampireArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected MagicEffectVampireArchetypeBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static MagicEffectVampireArchetypeBinaryOverlay MagicEffectVampireArchetypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new MagicEffectVampireArchetypeBinaryOverlay(
                bytes: stream.RemainingMemory,
                package: package);
            int offset = stream.Position;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static MagicEffectVampireArchetypeBinaryOverlay MagicEffectVampireArchetypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return MagicEffectVampireArchetypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            MagicEffectVampireArchetypeMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IMagicEffectVampireArchetypeGetter rhs)) return false;
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IMagicEffectVampireArchetypeGetter? obj)
        {
            return ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((MagicEffectVampireArchetypeCommon)((IMagicEffectVampireArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

