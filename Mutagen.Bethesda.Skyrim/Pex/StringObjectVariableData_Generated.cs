/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Pex;
using Mutagen.Bethesda.Pex.Binary.Translations;
using Mutagen.Bethesda.Skyrim.Pex;
using Mutagen.Bethesda.Skyrim.Pex.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim.Pex
{
    #region Class
    public partial class StringObjectVariableData :
        ObjectVariableData,
        IEquatable<IStringObjectVariableDataGetter>,
        ILoquiObjectSetter<StringObjectVariableData>,
        IStringObjectVariableData
    {
        #region Ctor
        public StringObjectVariableData()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Value
        public String Value { get; set; } = string.Empty;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            StringObjectVariableDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IStringObjectVariableDataGetter rhs) return false;
            return ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IStringObjectVariableDataGetter? obj)
        {
            return ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ObjectVariableData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Value)
            : base()
            {
                this.Value = Value;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Value;
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
                if (!object.Equals(this.Value, rhs.Value)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Value);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Value)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Value)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new StringObjectVariableData.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Value = eval(this.Value);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(StringObjectVariableData.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, StringObjectVariableData.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(StringObjectVariableData.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Value ?? true)
                    {
                        fg.AppendItem(Value, "Value");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            ObjectVariableData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Value;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                StringObjectVariableData_FieldIndex enu = (StringObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case StringObjectVariableData_FieldIndex.Value:
                        return Value;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                StringObjectVariableData_FieldIndex enu = (StringObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case StringObjectVariableData_FieldIndex.Value:
                        this.Value = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                StringObjectVariableData_FieldIndex enu = (StringObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case StringObjectVariableData_FieldIndex.Value:
                        this.Value = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Value != null) return true;
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
                fg.AppendItem(Value, "Value");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Value = this.Value.Combine(rhs.Value);
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
            ObjectVariableData.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Value;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Value = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Value, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Pex Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object PexWriteTranslator => StringObjectVariableDataPexWriteTranslation.Instance;
        void IPexItem.WriteToBinary(PexWriter writer)
        {
            ((StringObjectVariableDataPexWriteTranslation)this.PexWriteTranslator).Write(
                item: this,
                writer: writer);
        }
        #region Pex Create
        public new static StringObjectVariableData CreateFromBinary(PexReader reader)
        {
            var ret = new StringObjectVariableData();
            ((StringObjectVariableDataSetterCommon)((IStringObjectVariableDataGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                reader: reader);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            PexReader reader,
            out StringObjectVariableData item)
        {
            var startPos = reader.Position;
            item = CreateFromBinary(reader: reader);
            return startPos != reader.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((StringObjectVariableDataSetterCommon)((IStringObjectVariableDataGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new StringObjectVariableData GetNew()
        {
            return new StringObjectVariableData();
        }

    }
    #endregion

    #region Interface
    public partial interface IStringObjectVariableData :
        ILoquiObjectSetter<IStringObjectVariableData>,
        IObjectVariableData,
        IStringObjectVariableDataGetter
    {
        new String Value { get; set; }
    }

    public partial interface IStringObjectVariableDataGetter :
        IObjectVariableDataGetter,
        ILoquiObject<IStringObjectVariableDataGetter>,
        IPexItem
    {
        static new ILoquiRegistration Registration => StringObjectVariableData_Registration.Instance;
        String Value { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class StringObjectVariableDataMixIn
    {
        public static void Clear(this IStringObjectVariableData item)
        {
            ((StringObjectVariableDataSetterCommon)((IStringObjectVariableDataGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static StringObjectVariableData.Mask<bool> GetEqualsMask(
            this IStringObjectVariableDataGetter item,
            IStringObjectVariableDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IStringObjectVariableDataGetter item,
            string? name = null,
            StringObjectVariableData.Mask<bool>? printMask = null)
        {
            return ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IStringObjectVariableDataGetter item,
            FileGeneration fg,
            string? name = null,
            StringObjectVariableData.Mask<bool>? printMask = null)
        {
            ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IStringObjectVariableDataGetter item,
            IStringObjectVariableDataGetter rhs,
            StringObjectVariableData.TranslationMask? equalsMask = null)
        {
            return ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IStringObjectVariableData lhs,
            IStringObjectVariableDataGetter rhs,
            out StringObjectVariableData.ErrorMask errorMask,
            StringObjectVariableData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = StringObjectVariableData.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IStringObjectVariableData lhs,
            IStringObjectVariableDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static StringObjectVariableData DeepCopy(
            this IStringObjectVariableDataGetter item,
            StringObjectVariableData.TranslationMask? copyMask = null)
        {
            return ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static StringObjectVariableData DeepCopy(
            this IStringObjectVariableDataGetter item,
            out StringObjectVariableData.ErrorMask errorMask,
            StringObjectVariableData.TranslationMask? copyMask = null)
        {
            return ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static StringObjectVariableData DeepCopy(
            this IStringObjectVariableDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Pex Translation
        public static void CopyInFromBinary(
            this IStringObjectVariableData item,
            PexReader reader)
        {
            ((StringObjectVariableDataSetterCommon)((IStringObjectVariableDataGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                reader: reader);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Pex.Internals
{
    #region Field Index
    public enum StringObjectVariableData_FieldIndex
    {
        Value = 0,
    }
    #endregion

    #region Registration
    public partial class StringObjectVariableData_Registration : ILoquiRegistration
    {
        public static readonly StringObjectVariableData_Registration Instance = new StringObjectVariableData_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_SkyrimPex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_SkyrimPex.ProtocolKey,
            msgID: 17,
            version: 0);

        public const string GUID = "06414205-5d74-4c6b-913e-5dfd9f41497b";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(StringObjectVariableData.Mask<>);

        public static readonly Type ErrorMaskType = typeof(StringObjectVariableData.ErrorMask);

        public static readonly Type ClassType = typeof(StringObjectVariableData);

        public static readonly Type GetterType = typeof(IStringObjectVariableDataGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IStringObjectVariableData);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Pex.StringObjectVariableData";

        public const string Name = "StringObjectVariableData";

        public const string Namespace = "Mutagen.Bethesda.Skyrim.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type PexWriteTranslation = typeof(StringObjectVariableDataPexWriteTranslation);
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
    public partial class StringObjectVariableDataSetterCommon : ObjectVariableDataSetterCommon
    {
        public new static readonly StringObjectVariableDataSetterCommon Instance = new StringObjectVariableDataSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IStringObjectVariableData item)
        {
            ClearPartial();
            item.Value = string.Empty;
            base.Clear(item);
        }
        
        public override void Clear(IObjectVariableData item)
        {
            Clear(item: (IStringObjectVariableData)item);
        }
        
        #region Pex Translation
        public virtual void CopyInFromBinary(
            IStringObjectVariableData item,
            PexReader reader)
        {
            item.Value = reader.ReadString();
        }
        
        public override void CopyInFromBinary(
            IObjectVariableData item,
            PexReader reader)
        {
            CopyInFromBinary(
                item: (StringObjectVariableData)item,
                reader: reader);
        }
        
        #endregion
        
    }
    public partial class StringObjectVariableDataCommon : ObjectVariableDataCommon
    {
        public new static readonly StringObjectVariableDataCommon Instance = new StringObjectVariableDataCommon();

        public StringObjectVariableData.Mask<bool> GetEqualsMask(
            IStringObjectVariableDataGetter item,
            IStringObjectVariableDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new StringObjectVariableData.Mask<bool>(false);
            ((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IStringObjectVariableDataGetter item,
            IStringObjectVariableDataGetter rhs,
            StringObjectVariableData.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Value = string.Equals(item.Value, rhs.Value);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IStringObjectVariableDataGetter item,
            string? name = null,
            StringObjectVariableData.Mask<bool>? printMask = null)
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
            IStringObjectVariableDataGetter item,
            FileGeneration fg,
            string? name = null,
            StringObjectVariableData.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"StringObjectVariableData =>");
            }
            else
            {
                fg.AppendLine($"{name} (StringObjectVariableData) =>");
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
            IStringObjectVariableDataGetter item,
            FileGeneration fg,
            StringObjectVariableData.Mask<bool>? printMask = null)
        {
            ObjectVariableDataCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Value ?? true)
            {
                fg.AppendItem(item.Value, "Value");
            }
        }
        
        public static StringObjectVariableData_FieldIndex ConvertFieldIndex(ObjectVariableData_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IStringObjectVariableDataGetter? lhs,
            IStringObjectVariableDataGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IObjectVariableDataGetter)lhs, (IObjectVariableDataGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)StringObjectVariableData_FieldIndex.Value) ?? true))
            {
                if (!string.Equals(lhs.Value, rhs.Value)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IObjectVariableDataGetter? lhs,
            IObjectVariableDataGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IStringObjectVariableDataGetter?)lhs,
                rhs: rhs as IStringObjectVariableDataGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IStringObjectVariableDataGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Value);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IObjectVariableDataGetter item)
        {
            return GetHashCode(item: (IStringObjectVariableDataGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return StringObjectVariableData.GetNew();
        }
        
    }
    public partial class StringObjectVariableDataSetterTranslationCommon : ObjectVariableDataSetterTranslationCommon
    {
        public new static readonly StringObjectVariableDataSetterTranslationCommon Instance = new StringObjectVariableDataSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IStringObjectVariableData item,
            IStringObjectVariableDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IObjectVariableData)item,
                (IObjectVariableDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)StringObjectVariableData_FieldIndex.Value) ?? true))
            {
                item.Value = rhs.Value;
            }
        }
        
        
        public override void DeepCopyIn(
            IObjectVariableData item,
            IObjectVariableDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IStringObjectVariableData)item,
                rhs: (IStringObjectVariableDataGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public StringObjectVariableData DeepCopy(
            IStringObjectVariableDataGetter item,
            StringObjectVariableData.TranslationMask? copyMask = null)
        {
            StringObjectVariableData ret = (StringObjectVariableData)((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public StringObjectVariableData DeepCopy(
            IStringObjectVariableDataGetter item,
            out StringObjectVariableData.ErrorMask errorMask,
            StringObjectVariableData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            StringObjectVariableData ret = (StringObjectVariableData)((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = StringObjectVariableData.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public StringObjectVariableData DeepCopy(
            IStringObjectVariableDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            StringObjectVariableData ret = (StringObjectVariableData)((StringObjectVariableDataCommon)((IStringObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((StringObjectVariableDataSetterTranslationCommon)((IStringObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Skyrim.Pex
{
    public partial class StringObjectVariableData
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => StringObjectVariableData_Registration.Instance;
        public new static StringObjectVariableData_Registration Registration => StringObjectVariableData_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => StringObjectVariableDataCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return StringObjectVariableDataSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => StringObjectVariableDataSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Pex Translation
namespace Mutagen.Bethesda.Skyrim.Pex.Internals
{
    public partial class StringObjectVariableDataPexWriteTranslation :
        ObjectVariableDataPexWriteTranslation,
        IPexWriteTranslator
    {
        public new readonly static StringObjectVariableDataPexWriteTranslation Instance = new StringObjectVariableDataPexWriteTranslation();

        public void Write(
            PexWriter writer,
            IStringObjectVariableDataGetter item)
        {
            ObjectVariableDataPexWriteTranslation.Instance.Write(
                item: item,
                writer: writer);
            writer.Write(item.Value);
        }

        public override void Write(
            PexWriter writer,
            object item)
        {
            Write(
                item: (IStringObjectVariableDataGetter)item,
                writer: writer);
        }

        public override void Write(
            PexWriter writer,
            IObjectVariableDataGetter item)
        {
            Write(
                item: (IStringObjectVariableDataGetter)item,
                writer: writer);
        }

    }

    public partial class StringObjectVariableDataPexCreateTranslation : ObjectVariableDataPexCreateTranslation
    {
        public new readonly static StringObjectVariableDataPexCreateTranslation Instance = new StringObjectVariableDataPexCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim.Pex
{
    #region Pex Write Mixins
    public static class StringObjectVariableDataPexTranslationMixIn
    {
    }
    #endregion


}
#endregion

#endregion

