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
    public partial class NpcLevel :
        ANpcLevel,
        INpcLevel,
        ILoquiObjectSetter<NpcLevel>,
        IEquatable<INpcLevelGetter>
    {
        #region Ctor
        public NpcLevel()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Level
        public Int16 Level { get; set; } = default;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            NpcLevelMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is INpcLevelGetter rhs)) return false;
            return ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(INpcLevelGetter? obj)
        {
            return ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ANpcLevel.Mask<TItem>,
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem Level)
            : base()
            {
                this.Level = Level;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Level;
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
                if (!object.Equals(this.Level, rhs.Level)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Level);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Level)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Level)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new NpcLevel.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Level = eval(this.Level);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(NpcLevel.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, NpcLevel.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(NpcLevel.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Level ?? true)
                    {
                        fg.AppendItem(Level, "Level");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            ANpcLevel.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Level;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                NpcLevel_FieldIndex enu = (NpcLevel_FieldIndex)index;
                switch (enu)
                {
                    case NpcLevel_FieldIndex.Level:
                        return Level;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                NpcLevel_FieldIndex enu = (NpcLevel_FieldIndex)index;
                switch (enu)
                {
                    case NpcLevel_FieldIndex.Level:
                        this.Level = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                NpcLevel_FieldIndex enu = (NpcLevel_FieldIndex)index;
                switch (enu)
                {
                    case NpcLevel_FieldIndex.Level:
                        this.Level = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Level != null) return true;
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
                fg.AppendItem(Level, "Level");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Level = this.Level.Combine(rhs.Level);
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
            ANpcLevel.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Level;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Level = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Level, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => NpcLevelBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((NpcLevelBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static NpcLevel CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new NpcLevel();
            ((NpcLevelSetterCommon)((INpcLevelGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out NpcLevel item,
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
            ((NpcLevelSetterCommon)((INpcLevelGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new NpcLevel GetNew()
        {
            return new NpcLevel();
        }

    }
    #endregion

    #region Interface
    public partial interface INpcLevel :
        INpcLevelGetter,
        IANpcLevel,
        ILoquiObjectSetter<INpcLevel>
    {
        new Int16 Level { get; set; }
    }

    public partial interface INpcLevelGetter :
        IANpcLevelGetter,
        ILoquiObject<INpcLevelGetter>,
        IBinaryItem
    {
        static new ILoquiRegistration Registration => NpcLevel_Registration.Instance;
        Int16 Level { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class NpcLevelMixIn
    {
        public static void Clear(this INpcLevel item)
        {
            ((NpcLevelSetterCommon)((INpcLevelGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static NpcLevel.Mask<bool> GetEqualsMask(
            this INpcLevelGetter item,
            INpcLevelGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this INpcLevelGetter item,
            string? name = null,
            NpcLevel.Mask<bool>? printMask = null)
        {
            return ((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this INpcLevelGetter item,
            FileGeneration fg,
            string? name = null,
            NpcLevel.Mask<bool>? printMask = null)
        {
            ((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this INpcLevelGetter item,
            INpcLevelGetter rhs)
        {
            return ((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this INpcLevel lhs,
            INpcLevelGetter rhs,
            out NpcLevel.ErrorMask errorMask,
            NpcLevel.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = NpcLevel.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this INpcLevel lhs,
            INpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static NpcLevel DeepCopy(
            this INpcLevelGetter item,
            NpcLevel.TranslationMask? copyMask = null)
        {
            return ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static NpcLevel DeepCopy(
            this INpcLevelGetter item,
            out NpcLevel.ErrorMask errorMask,
            NpcLevel.TranslationMask? copyMask = null)
        {
            return ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static NpcLevel DeepCopy(
            this INpcLevelGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this INpcLevel item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((NpcLevelSetterCommon)((INpcLevelGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum NpcLevel_FieldIndex
    {
        Level = 0,
    }
    #endregion

    #region Registration
    public partial class NpcLevel_Registration : ILoquiRegistration
    {
        public static readonly NpcLevel_Registration Instance = new NpcLevel_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 203,
            version: 0);

        public const string GUID = "b24f6b29-d611-400d-b56f-22332bacb9d2";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(NpcLevel.Mask<>);

        public static readonly Type ErrorMaskType = typeof(NpcLevel.ErrorMask);

        public static readonly Type ClassType = typeof(NpcLevel);

        public static readonly Type GetterType = typeof(INpcLevelGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(INpcLevel);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.NpcLevel";

        public const string Name = "NpcLevel";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(NpcLevelBinaryWriteTranslation);
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
    public partial class NpcLevelSetterCommon : ANpcLevelSetterCommon
    {
        public new static readonly NpcLevelSetterCommon Instance = new NpcLevelSetterCommon();

        partial void ClearPartial();
        
        public void Clear(INpcLevel item)
        {
            ClearPartial();
            item.Level = default;
            base.Clear(item);
        }
        
        public override void Clear(IANpcLevel item)
        {
            Clear(item: (INpcLevel)item);
        }
        
        #region Mutagen
        public void RemapLinks(INpcLevel obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            INpcLevel item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: NpcLevelBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IANpcLevel item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (NpcLevel)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class NpcLevelCommon : ANpcLevelCommon
    {
        public new static readonly NpcLevelCommon Instance = new NpcLevelCommon();

        public NpcLevel.Mask<bool> GetEqualsMask(
            INpcLevelGetter item,
            INpcLevelGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new NpcLevel.Mask<bool>(false);
            ((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            INpcLevelGetter item,
            INpcLevelGetter rhs,
            NpcLevel.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Level = item.Level == rhs.Level;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            INpcLevelGetter item,
            string? name = null,
            NpcLevel.Mask<bool>? printMask = null)
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
            INpcLevelGetter item,
            FileGeneration fg,
            string? name = null,
            NpcLevel.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"NpcLevel =>");
            }
            else
            {
                fg.AppendLine($"{name} (NpcLevel) =>");
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
            INpcLevelGetter item,
            FileGeneration fg,
            NpcLevel.Mask<bool>? printMask = null)
        {
            ANpcLevelCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Level ?? true)
            {
                fg.AppendItem(item.Level, "Level");
            }
        }
        
        public static NpcLevel_FieldIndex ConvertFieldIndex(ANpcLevel_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            INpcLevelGetter? lhs,
            INpcLevelGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IANpcLevelGetter)lhs, (IANpcLevelGetter)rhs)) return false;
            if (lhs.Level != rhs.Level) return false;
            return true;
        }
        
        public override bool Equals(
            IANpcLevelGetter? lhs,
            IANpcLevelGetter? rhs)
        {
            return Equals(
                lhs: (INpcLevelGetter?)lhs,
                rhs: rhs as INpcLevelGetter);
        }
        
        public virtual int GetHashCode(INpcLevelGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Level);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IANpcLevelGetter item)
        {
            return GetHashCode(item: (INpcLevelGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return NpcLevel.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(INpcLevelGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class NpcLevelSetterTranslationCommon : ANpcLevelSetterTranslationCommon
    {
        public new static readonly NpcLevelSetterTranslationCommon Instance = new NpcLevelSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            INpcLevel item,
            INpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IANpcLevel)item,
                (IANpcLevelGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)NpcLevel_FieldIndex.Level) ?? true))
            {
                item.Level = rhs.Level;
            }
        }
        
        
        public override void DeepCopyIn(
            IANpcLevel item,
            IANpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (INpcLevel)item,
                rhs: (INpcLevelGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public NpcLevel DeepCopy(
            INpcLevelGetter item,
            NpcLevel.TranslationMask? copyMask = null)
        {
            NpcLevel ret = (NpcLevel)((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).GetNew();
            ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public NpcLevel DeepCopy(
            INpcLevelGetter item,
            out NpcLevel.ErrorMask errorMask,
            NpcLevel.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            NpcLevel ret = (NpcLevel)((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).GetNew();
            ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = NpcLevel.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public NpcLevel DeepCopy(
            INpcLevelGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            NpcLevel ret = (NpcLevel)((NpcLevelCommon)((INpcLevelGetter)item).CommonInstance()!).GetNew();
            ((NpcLevelSetterTranslationCommon)((INpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class NpcLevel
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NpcLevel_Registration.Instance;
        public new static NpcLevel_Registration Registration => NpcLevel_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => NpcLevelCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return NpcLevelSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => NpcLevelSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class NpcLevelBinaryWriteTranslation :
        ANpcLevelBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static NpcLevelBinaryWriteTranslation Instance = new NpcLevelBinaryWriteTranslation();

        public static void WriteEmbedded(
            INpcLevelGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Level);
        }

        public void Write(
            MutagenWriter writer,
            INpcLevelGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (INpcLevelGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IANpcLevelGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (INpcLevelGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class NpcLevelBinaryCreateTranslation : ANpcLevelBinaryCreateTranslation
    {
        public new readonly static NpcLevelBinaryCreateTranslation Instance = new NpcLevelBinaryCreateTranslation();

        public static void FillBinaryStructs(
            INpcLevel item,
            MutagenFrame frame)
        {
            item.Level = frame.ReadInt16();
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class NpcLevelBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class NpcLevelBinaryOverlay :
        ANpcLevelBinaryOverlay,
        INpcLevelGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NpcLevel_Registration.Instance;
        public new static NpcLevel_Registration Registration => NpcLevel_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => NpcLevelCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => NpcLevelSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => NpcLevelBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((NpcLevelBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Int16 Level => BinaryPrimitives.ReadInt16LittleEndian(_data.Slice(0x0, 0x2));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected NpcLevelBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static NpcLevelBinaryOverlay NpcLevelFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new NpcLevelBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x2),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x2;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static NpcLevelBinaryOverlay NpcLevelFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return NpcLevelFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            NpcLevelMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is INpcLevelGetter rhs)) return false;
            return ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(INpcLevelGetter? obj)
        {
            return ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((NpcLevelCommon)((INpcLevelGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

