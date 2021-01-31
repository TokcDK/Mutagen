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
    public partial class PackageRoot :
        IEquatable<IPackageRootGetter>,
        ILoquiObjectSetter<PackageRoot>,
        IPackageRoot
    {
        #region Ctor
        public PackageRoot()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region BranchCount
        public Int32 BranchCount { get; set; } = default;
        #endregion
        #region Flags
        public PackageRoot.Flag Flags { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PackageRootMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPackageRootGetter rhs)) return false;
            return ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPackageRootGetter? obj)
        {
            return ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.BranchCount = initialValue;
                this.Flags = initialValue;
            }

            public Mask(
                TItem BranchCount,
                TItem Flags)
            {
                this.BranchCount = BranchCount;
                this.Flags = Flags;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem BranchCount;
            public TItem Flags;
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
                if (!object.Equals(this.BranchCount, rhs.BranchCount)) return false;
                if (!object.Equals(this.Flags, rhs.Flags)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.BranchCount);
                hash.Add(this.Flags);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.BranchCount)) return false;
                if (!eval(this.Flags)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.BranchCount)) return true;
                if (eval(this.Flags)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PackageRoot.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.BranchCount = eval(this.BranchCount);
                obj.Flags = eval(this.Flags);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(PackageRoot.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, PackageRoot.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(PackageRoot.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.BranchCount ?? true)
                    {
                        fg.AppendItem(BranchCount, "BranchCount");
                    }
                    if (printMask?.Flags ?? true)
                    {
                        fg.AppendItem(Flags, "Flags");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? BranchCount;
            public Exception? Flags;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                PackageRoot_FieldIndex enu = (PackageRoot_FieldIndex)index;
                switch (enu)
                {
                    case PackageRoot_FieldIndex.BranchCount:
                        return BranchCount;
                    case PackageRoot_FieldIndex.Flags:
                        return Flags;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                PackageRoot_FieldIndex enu = (PackageRoot_FieldIndex)index;
                switch (enu)
                {
                    case PackageRoot_FieldIndex.BranchCount:
                        this.BranchCount = ex;
                        break;
                    case PackageRoot_FieldIndex.Flags:
                        this.Flags = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                PackageRoot_FieldIndex enu = (PackageRoot_FieldIndex)index;
                switch (enu)
                {
                    case PackageRoot_FieldIndex.BranchCount:
                        this.BranchCount = (Exception?)obj;
                        break;
                    case PackageRoot_FieldIndex.Flags:
                        this.Flags = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (BranchCount != null) return true;
                if (Flags != null) return true;
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

            public void ToString(FileGeneration fg, string? name = null)
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
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(BranchCount, "BranchCount");
                fg.AppendItem(Flags, "Flags");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.BranchCount = this.BranchCount.Combine(rhs.BranchCount);
                ret.Flags = this.Flags.Combine(rhs.Flags);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool BranchCount;
            public bool Flags;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.BranchCount = defaultOn;
                this.Flags = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((BranchCount, null));
                ret.Add((Flags, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PackageRootBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageRootBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static PackageRoot CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PackageRoot();
            ((PackageRootSetterCommon)((IPackageRootGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out PackageRoot item,
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
            ((PackageRootSetterCommon)((IPackageRootGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static PackageRoot GetNew()
        {
            return new PackageRoot();
        }

    }
    #endregion

    #region Interface
    public partial interface IPackageRoot :
        ILoquiObjectSetter<IPackageRoot>,
        IPackageRootGetter
    {
        new Int32 BranchCount { get; set; }
        new PackageRoot.Flag Flags { get; set; }
    }

    public partial interface IPackageRootGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IPackageRootGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => PackageRoot_Registration.Instance;
        Int32 BranchCount { get; }
        PackageRoot.Flag Flags { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PackageRootMixIn
    {
        public static void Clear(this IPackageRoot item)
        {
            ((PackageRootSetterCommon)((IPackageRootGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PackageRoot.Mask<bool> GetEqualsMask(
            this IPackageRootGetter item,
            IPackageRootGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPackageRootGetter item,
            string? name = null,
            PackageRoot.Mask<bool>? printMask = null)
        {
            return ((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPackageRootGetter item,
            FileGeneration fg,
            string? name = null,
            PackageRoot.Mask<bool>? printMask = null)
        {
            ((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPackageRootGetter item,
            IPackageRootGetter rhs)
        {
            return ((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IPackageRoot lhs,
            IPackageRootGetter rhs)
        {
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPackageRoot lhs,
            IPackageRootGetter rhs,
            PackageRoot.TranslationMask? copyMask = null)
        {
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPackageRoot lhs,
            IPackageRootGetter rhs,
            out PackageRoot.ErrorMask errorMask,
            PackageRoot.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PackageRoot.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPackageRoot lhs,
            IPackageRootGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PackageRoot DeepCopy(
            this IPackageRootGetter item,
            PackageRoot.TranslationMask? copyMask = null)
        {
            return ((PackageRootSetterTranslationCommon)((IPackageRootGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PackageRoot DeepCopy(
            this IPackageRootGetter item,
            out PackageRoot.ErrorMask errorMask,
            PackageRoot.TranslationMask? copyMask = null)
        {
            return ((PackageRootSetterTranslationCommon)((IPackageRootGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PackageRoot DeepCopy(
            this IPackageRootGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PackageRootSetterTranslationCommon)((IPackageRootGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPackageRoot item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageRootSetterCommon)((IPackageRootGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum PackageRoot_FieldIndex
    {
        BranchCount = 0,
        Flags = 1,
    }
    #endregion

    #region Registration
    public partial class PackageRoot_Registration : ILoquiRegistration
    {
        public static readonly PackageRoot_Registration Instance = new PackageRoot_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 384,
            version: 0);

        public const string GUID = "361121b0-bd00-444e-a906-a72e443ae85b";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PackageRoot.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PackageRoot.ErrorMask);

        public static readonly Type ClassType = typeof(PackageRoot);

        public static readonly Type GetterType = typeof(IPackageRootGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPackageRoot);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.PackageRoot";

        public const string Name = "PackageRoot";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(PackageRootBinaryWriteTranslation);
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
    public partial class PackageRootSetterCommon
    {
        public static readonly PackageRootSetterCommon Instance = new PackageRootSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPackageRoot item)
        {
            ClearPartial();
            item.BranchCount = default;
            item.Flags = default;
        }
        
        #region Mutagen
        public void RemapLinks(IPackageRoot obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPackageRoot item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: PackageRootBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class PackageRootCommon
    {
        public static readonly PackageRootCommon Instance = new PackageRootCommon();

        public PackageRoot.Mask<bool> GetEqualsMask(
            IPackageRootGetter item,
            IPackageRootGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PackageRoot.Mask<bool>(false);
            ((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPackageRootGetter item,
            IPackageRootGetter rhs,
            PackageRoot.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.BranchCount = item.BranchCount == rhs.BranchCount;
            ret.Flags = item.Flags == rhs.Flags;
        }
        
        public string ToString(
            IPackageRootGetter item,
            string? name = null,
            PackageRoot.Mask<bool>? printMask = null)
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
            IPackageRootGetter item,
            FileGeneration fg,
            string? name = null,
            PackageRoot.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"PackageRoot =>");
            }
            else
            {
                fg.AppendLine($"{name} (PackageRoot) =>");
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
            IPackageRootGetter item,
            FileGeneration fg,
            PackageRoot.Mask<bool>? printMask = null)
        {
            if (printMask?.BranchCount ?? true)
            {
                fg.AppendItem(item.BranchCount, "BranchCount");
            }
            if (printMask?.Flags ?? true)
            {
                fg.AppendItem(item.Flags, "Flags");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPackageRootGetter? lhs,
            IPackageRootGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (lhs.BranchCount != rhs.BranchCount) return false;
            if (lhs.Flags != rhs.Flags) return false;
            return true;
        }
        
        public virtual int GetHashCode(IPackageRootGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.BranchCount);
            hash.Add(item.Flags);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return PackageRoot.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IPackageRootGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class PackageRootSetterTranslationCommon
    {
        public static readonly PackageRootSetterTranslationCommon Instance = new PackageRootSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPackageRoot item,
            IPackageRootGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)PackageRoot_FieldIndex.BranchCount) ?? true))
            {
                item.BranchCount = rhs.BranchCount;
            }
            if ((copyMask?.GetShouldTranslate((int)PackageRoot_FieldIndex.Flags) ?? true))
            {
                item.Flags = rhs.Flags;
            }
        }
        
        #endregion
        
        public PackageRoot DeepCopy(
            IPackageRootGetter item,
            PackageRoot.TranslationMask? copyMask = null)
        {
            PackageRoot ret = (PackageRoot)((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).GetNew();
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PackageRoot DeepCopy(
            IPackageRootGetter item,
            out PackageRoot.ErrorMask errorMask,
            PackageRoot.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PackageRoot ret = (PackageRoot)((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).GetNew();
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PackageRoot.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PackageRoot DeepCopy(
            IPackageRootGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PackageRoot ret = (PackageRoot)((PackageRootCommon)((IPackageRootGetter)item).CommonInstance()!).GetNew();
            ((PackageRootSetterTranslationCommon)((IPackageRootGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class PackageRoot
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageRoot_Registration.Instance;
        public static PackageRoot_Registration Registration => PackageRoot_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PackageRootCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PackageRootSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PackageRootSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPackageRootGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPackageRootGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPackageRootGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PackageRootBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static PackageRootBinaryWriteTranslation Instance = new PackageRootBinaryWriteTranslation();

        public static void WriteEmbedded(
            IPackageRootGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.BranchCount);
            Mutagen.Bethesda.Binary.EnumBinaryTranslation<PackageRoot.Flag>.Instance.Write(
                writer,
                item.Flags,
                length: 4);
        }

        public void Write(
            MutagenWriter writer,
            IPackageRootGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IPackageRootGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class PackageRootBinaryCreateTranslation
    {
        public readonly static PackageRootBinaryCreateTranslation Instance = new PackageRootBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPackageRoot item,
            MutagenFrame frame)
        {
            item.BranchCount = frame.ReadInt32();
            item.Flags = EnumBinaryTranslation<PackageRoot.Flag>.Instance.Parse(frame: frame.SpawnWithLength(4));
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class PackageRootBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IPackageRootGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageRootBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PackageRootBinaryOverlay :
        BinaryOverlay,
        IPackageRootGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageRoot_Registration.Instance;
        public static PackageRoot_Registration Registration => PackageRoot_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PackageRootCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PackageRootSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPackageRootGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IPackageRootGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IPackageRootGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PackageRootBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PackageRootBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Int32 BranchCount => BinaryPrimitives.ReadInt32LittleEndian(_data.Slice(0x0, 0x4));
        public PackageRoot.Flag Flags => (PackageRoot.Flag)BinaryPrimitives.ReadInt32LittleEndian(_data.Span.Slice(0x4, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PackageRootBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static PackageRootBinaryOverlay PackageRootFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PackageRootBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x8),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x8;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static PackageRootBinaryOverlay PackageRootFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return PackageRootFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PackageRootMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPackageRootGetter rhs)) return false;
            return ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPackageRootGetter? obj)
        {
            return ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PackageRootCommon)((IPackageRootGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

