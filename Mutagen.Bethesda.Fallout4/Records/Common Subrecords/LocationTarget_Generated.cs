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
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class LocationTarget :
        ALocationTarget,
        IEquatable<ILocationTargetGetter>,
        ILocationTarget,
        ILoquiObjectSetter<LocationTarget>
    {
        #region Ctor
        public LocationTarget()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Link
        private readonly IFormLink<ILocationTargetableGetter> _Link = new FormLink<ILocationTargetableGetter>();
        public IFormLink<ILocationTargetableGetter> Link
        {
            get => _Link;
            set => _Link.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<ILocationTargetableGetter> ILocationTargetGetter.Link => this.Link;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationTargetMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationTargetGetter rhs) return false;
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ILocationTargetGetter? obj)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ALocationTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Link)
            : base()
            {
                this.Link = Link;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Link;
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
                if (!object.Equals(this.Link, rhs.Link)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Link);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Link)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Link)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new LocationTarget.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Link = eval(this.Link);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(LocationTarget.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, LocationTarget.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(LocationTarget.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Link ?? true)
                    {
                        sb.AppendItem(Link, "Link");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ALocationTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Link;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                LocationTarget_FieldIndex enu = (LocationTarget_FieldIndex)index;
                switch (enu)
                {
                    case LocationTarget_FieldIndex.Link:
                        return Link;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                LocationTarget_FieldIndex enu = (LocationTarget_FieldIndex)index;
                switch (enu)
                {
                    case LocationTarget_FieldIndex.Link:
                        this.Link = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                LocationTarget_FieldIndex enu = (LocationTarget_FieldIndex)index;
                switch (enu)
                {
                    case LocationTarget_FieldIndex.Link:
                        this.Link = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Link != null) return true;
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
                {
                    sb.AppendItem(Link, "Link");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Link = this.Link.Combine(rhs.Link);
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
            ALocationTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Link;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Link = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Link, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => LocationTargetCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => LocationTargetSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationTargetBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((LocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static LocationTarget CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new LocationTarget();
            ((LocationTargetSetterCommon)((ILocationTargetGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out LocationTarget item,
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
            ((LocationTargetSetterCommon)((ILocationTargetGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new LocationTarget GetNew()
        {
            return new LocationTarget();
        }

    }
    #endregion

    #region Interface
    public partial interface ILocationTarget :
        IALocationTarget,
        IFormLinkContainer,
        ILocationTargetGetter,
        ILoquiObjectSetter<ILocationTarget>
    {
        new IFormLink<ILocationTargetableGetter> Link { get; set; }
    }

    public partial interface ILocationTargetGetter :
        IALocationTargetGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<ILocationTargetGetter>
    {
        static new ILoquiRegistration StaticRegistration => LocationTarget_Registration.Instance;
        IFormLinkGetter<ILocationTargetableGetter> Link { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class LocationTargetMixIn
    {
        public static void Clear(this ILocationTarget item)
        {
            ((LocationTargetSetterCommon)((ILocationTargetGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static LocationTarget.Mask<bool> GetEqualsMask(
            this ILocationTargetGetter item,
            ILocationTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this ILocationTargetGetter item,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this ILocationTargetGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ILocationTargetGetter item,
            ILocationTargetGetter rhs,
            LocationTarget.TranslationMask? equalsMask = null)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ILocationTarget lhs,
            ILocationTargetGetter rhs,
            out LocationTarget.ErrorMask errorMask,
            LocationTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = LocationTarget.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ILocationTarget lhs,
            ILocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static LocationTarget DeepCopy(
            this ILocationTargetGetter item,
            LocationTarget.TranslationMask? copyMask = null)
        {
            return ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static LocationTarget DeepCopy(
            this ILocationTargetGetter item,
            out LocationTarget.ErrorMask errorMask,
            LocationTarget.TranslationMask? copyMask = null)
        {
            return ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static LocationTarget DeepCopy(
            this ILocationTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ILocationTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((LocationTargetSetterCommon)((ILocationTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum LocationTarget_FieldIndex
    {
        Link = 0,
    }
    #endregion

    #region Registration
    internal partial class LocationTarget_Registration : ILoquiRegistration
    {
        public static readonly LocationTarget_Registration Instance = new LocationTarget_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 62,
            version: 0);

        public const string GUID = "498d0751-d029-4bf4-b7ab-310a41ae4176";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(LocationTarget.Mask<>);

        public static readonly Type ErrorMaskType = typeof(LocationTarget.ErrorMask);

        public static readonly Type ClassType = typeof(LocationTarget);

        public static readonly Type GetterType = typeof(ILocationTargetGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ILocationTarget);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.LocationTarget";

        public const string Name = "LocationTarget";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(LocationTargetBinaryWriteTranslation);
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
    internal partial class LocationTargetSetterCommon : ALocationTargetSetterCommon
    {
        public new static readonly LocationTargetSetterCommon Instance = new LocationTargetSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ILocationTarget item)
        {
            ClearPartial();
            item.Link.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IALocationTarget item)
        {
            Clear(item: (ILocationTarget)item);
        }
        
        #region Mutagen
        public void RemapLinks(ILocationTarget obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Link.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ILocationTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: LocationTargetBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IALocationTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (LocationTarget)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class LocationTargetCommon : ALocationTargetCommon
    {
        public new static readonly LocationTargetCommon Instance = new LocationTargetCommon();

        public LocationTarget.Mask<bool> GetEqualsMask(
            ILocationTargetGetter item,
            ILocationTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new LocationTarget.Mask<bool>(false);
            ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ILocationTargetGetter item,
            ILocationTargetGetter rhs,
            LocationTarget.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Link = item.Link.Equals(rhs.Link);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            ILocationTargetGetter item,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
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
            ILocationTargetGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"LocationTarget =>");
            }
            else
            {
                sb.AppendLine($"{name} (LocationTarget) =>");
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
            ILocationTargetGetter item,
            StructuredStringBuilder sb,
            LocationTarget.Mask<bool>? printMask = null)
        {
            ALocationTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Link ?? true)
            {
                sb.AppendItem(item.Link.FormKey, "Link");
            }
        }
        
        public static LocationTarget_FieldIndex ConvertFieldIndex(ALocationTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILocationTargetGetter? lhs,
            ILocationTargetGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IALocationTargetGetter)lhs, (IALocationTargetGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)LocationTarget_FieldIndex.Link) ?? true))
            {
                if (!lhs.Link.Equals(rhs.Link)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IALocationTargetGetter? lhs,
            IALocationTargetGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (ILocationTargetGetter?)lhs,
                rhs: rhs as ILocationTargetGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(ILocationTargetGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Link);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IALocationTargetGetter item)
        {
            return GetHashCode(item: (ILocationTargetGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return LocationTarget.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(ILocationTargetGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Link);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class LocationTargetSetterTranslationCommon : ALocationTargetSetterTranslationCommon
    {
        public new static readonly LocationTargetSetterTranslationCommon Instance = new LocationTargetSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ILocationTarget item,
            ILocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IALocationTarget)item,
                (IALocationTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)LocationTarget_FieldIndex.Link) ?? true))
            {
                item.Link.SetTo(rhs.Link.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IALocationTarget item,
            IALocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (ILocationTarget)item,
                rhs: (ILocationTargetGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public LocationTarget DeepCopy(
            ILocationTargetGetter item,
            LocationTarget.TranslationMask? copyMask = null)
        {
            LocationTarget ret = (LocationTarget)((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).GetNew();
            ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public LocationTarget DeepCopy(
            ILocationTargetGetter item,
            out LocationTarget.ErrorMask errorMask,
            LocationTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            LocationTarget ret = (LocationTarget)((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).GetNew();
            ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = LocationTarget.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public LocationTarget DeepCopy(
            ILocationTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            LocationTarget ret = (LocationTarget)((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).GetNew();
            ((LocationTargetSetterTranslationCommon)((ILocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Fallout4
{
    public partial class LocationTarget
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationTarget_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => LocationTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationTargetCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return LocationTargetSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationTargetSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class LocationTargetBinaryWriteTranslation :
        ALocationTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly LocationTargetBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            ILocationTargetGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Link);
        }

        public void Write(
            MutagenWriter writer,
            ILocationTargetGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (ILocationTargetGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IALocationTargetGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (ILocationTargetGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class LocationTargetBinaryCreateTranslation : ALocationTargetBinaryCreateTranslation
    {
        public new static readonly LocationTargetBinaryCreateTranslation Instance = new LocationTargetBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILocationTarget item,
            MutagenFrame frame)
        {
            item.Link.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class LocationTargetBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class LocationTargetBinaryOverlay :
        ALocationTargetBinaryOverlay,
        ILocationTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationTarget_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => LocationTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationTargetCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationTargetSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => LocationTargetCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationTargetBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((LocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public IFormLinkGetter<ILocationTargetableGetter> Link => new FormLink<ILocationTargetableGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_structData.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LocationTargetBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static ILocationTargetGetter LocationTargetFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new LocationTargetBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ILocationTargetGetter LocationTargetFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return LocationTargetFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationTargetMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationTargetGetter rhs) return false;
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ILocationTargetGetter? obj)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

