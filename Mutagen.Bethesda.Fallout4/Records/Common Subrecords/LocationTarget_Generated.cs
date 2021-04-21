/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Records;
using Mutagen.Bethesda.Records.Binary.Overlay;
using Mutagen.Bethesda.Records.Binary.Streams;
using Mutagen.Bethesda.Records.Binary.Translations;
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
        private IFormLink<ILocationTargetableGetter> _Link = new FormLink<ILocationTargetableGetter>();
        public IFormLink<ILocationTargetableGetter> Link
        {
            get => _Link;
            set => _Link = value.AsSetter();
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<ILocationTargetableGetter> ILocationTargetGetter.Link => this.Link;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LocationTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationTargetGetter rhs) return false;
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationTargetGetter? obj)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
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
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(LocationTarget.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, LocationTarget.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(LocationTarget.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Link ?? true)
                    {
                        fg.AppendItem(Link, "Link");
                    }
                }
                fg.AppendLine("]");
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
                fg.AppendItem(Link, "Link");
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
        public override IEnumerable<FormLinkInformation> ContainedFormLinks => LocationTargetCommon.Instance.GetContainedFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => LocationTargetSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationTargetBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static LocationTarget CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LocationTarget();
            ((LocationTargetSetterCommon)((ILocationTargetGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out LocationTarget item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

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
        new IFormLink<ILocationTargetableGetter> Link { get; }
    }

    public partial interface ILocationTargetGetter :
        IALocationTargetGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<ILocationTargetGetter>
    {
        static new ILoquiRegistration Registration => LocationTarget_Registration.Instance;
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

        public static string ToString(
            this ILocationTargetGetter item,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this ILocationTargetGetter item,
            FileGeneration fg,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            ((LocationTargetCommon)((ILocationTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
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
                crystal: equalsMask?.GetCrystal());
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
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationTargetSetterCommon)((ILocationTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4.Internals
{
    #region Field Index
    public enum LocationTarget_FieldIndex
    {
        Link = 0,
    }
    #endregion

    #region Registration
    public partial class LocationTarget_Registration : ILoquiRegistration
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
    public partial class LocationTargetSetterCommon : ALocationTargetSetterCommon
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
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: LocationTargetBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IALocationTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (LocationTarget)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class LocationTargetCommon : ALocationTargetCommon
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
            if (rhs == null) return;
            ret.Link = item.Link.Equals(rhs.Link);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            ILocationTargetGetter item,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
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
            ILocationTargetGetter item,
            FileGeneration fg,
            string? name = null,
            LocationTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"LocationTarget =>");
            }
            else
            {
                fg.AppendLine($"{name} (LocationTarget) =>");
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
            ILocationTargetGetter item,
            FileGeneration fg,
            LocationTarget.Mask<bool>? printMask = null)
        {
            ALocationTargetCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Link ?? true)
            {
                fg.AppendItem(item.Link.FormKey, "Link");
            }
        }
        
        public static LocationTarget_FieldIndex ConvertFieldIndex(ALocationTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILocationTargetGetter? lhs,
            ILocationTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IALocationTargetGetter)lhs, (IALocationTargetGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)LocationTarget_FieldIndex.Link) ?? true))
            {
                if (!lhs.Link.Equals(rhs.Link)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IALocationTargetGetter? lhs,
            IALocationTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (ILocationTargetGetter?)lhs,
                rhs: rhs as ILocationTargetGetter,
                crystal: crystal);
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
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(ILocationTargetGetter obj)
        {
            foreach (var item in base.GetContainedFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Link);
            yield break;
        }
        
        #endregion
        
    }
    public partial class LocationTargetSetterTranslationCommon : ALocationTargetSetterTranslationCommon
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
        public new static LocationTarget_Registration Registration => LocationTarget_Registration.Instance;
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
namespace Mutagen.Bethesda.Fallout4.Internals
{
    public partial class LocationTargetBinaryWriteTranslation :
        ALocationTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static LocationTargetBinaryWriteTranslation Instance = new LocationTargetBinaryWriteTranslation();

        public static void WriteEmbedded(
            ILocationTargetGetter item,
            MutagenWriter writer)
        {
            Mutagen.Bethesda.Records.Binary.Translations.FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Link);
        }

        public void Write(
            MutagenWriter writer,
            ILocationTargetGetter item,
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
                item: (ILocationTargetGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IALocationTargetGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (ILocationTargetGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class LocationTargetBinaryCreateTranslation : ALocationTargetBinaryCreateTranslation
    {
        public new readonly static LocationTargetBinaryCreateTranslation Instance = new LocationTargetBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILocationTarget item,
            MutagenFrame frame)
        {
            item.Link.SetTo(
                Mutagen.Bethesda.Records.Binary.Translations.FormLinkBinaryTranslation.Instance.Parse(
                    frame: frame,
                    defaultVal: FormKey.Null));
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
namespace Mutagen.Bethesda.Fallout4.Internals
{
    public partial class LocationTargetBinaryOverlay :
        ALocationTargetBinaryOverlay,
        ILocationTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationTarget_Registration.Instance;
        public new static LocationTarget_Registration Registration => LocationTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationTargetCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationTargetSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public override IEnumerable<FormLinkInformation> ContainedFormLinks => LocationTargetCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationTargetBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public IFormLinkGetter<ILocationTargetableGetter> Link => new FormLink<ILocationTargetableGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LocationTargetBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static LocationTargetBinaryOverlay LocationTargetFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LocationTargetBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static LocationTargetBinaryOverlay LocationTargetFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return LocationTargetFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LocationTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationTargetGetter rhs) return false;
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationTargetGetter? obj)
        {
            return ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationTargetCommon)((ILocationTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

