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
    /// <summary>
    /// Implemented by: [IdentifierVariable]
    /// </summary>
    public partial class StringVariable :
        AVariable,
        IEquatable<IStringVariableGetter>,
        ILoquiObjectSetter<StringVariable>,
        IStringVariable
    {
        #region Ctor
        public StringVariable()
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
            StringVariableMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IStringVariableGetter rhs) return false;
            return ((StringVariableCommon)((IStringVariableGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IStringVariableGetter? obj)
        {
            return ((StringVariableCommon)((IStringVariableGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((StringVariableCommon)((IStringVariableGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AVariable.Mask<TItem>,
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
                var ret = new StringVariable.Mask<R>();
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

            public string ToString(StringVariable.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, StringVariable.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(StringVariable.Mask<TItem>)} =>");
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
            AVariable.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Value;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                StringVariable_FieldIndex enu = (StringVariable_FieldIndex)index;
                switch (enu)
                {
                    case StringVariable_FieldIndex.Value:
                        return Value;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                StringVariable_FieldIndex enu = (StringVariable_FieldIndex)index;
                switch (enu)
                {
                    case StringVariable_FieldIndex.Value:
                        this.Value = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                StringVariable_FieldIndex enu = (StringVariable_FieldIndex)index;
                switch (enu)
                {
                    case StringVariable_FieldIndex.Value:
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
            AVariable.TranslationMask,
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
        protected override object PexWriteTranslator => StringVariablePexWriteTranslation.Instance;
        void IPexItem.WriteToBinary(PexWriter writer)
        {
            ((StringVariablePexWriteTranslation)this.PexWriteTranslator).Write(
                item: this,
                writer: writer);
        }
        #region Pex Create
        public new static StringVariable CreateFromBinary(PexReader reader)
        {
            var ret = new StringVariable();
            ((StringVariableSetterCommon)((IStringVariableGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                reader: reader);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            PexReader reader,
            out StringVariable item)
        {
            var startPos = reader.Position;
            item = CreateFromBinary(reader: reader);
            return startPos != reader.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((StringVariableSetterCommon)((IStringVariableGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new StringVariable GetNew()
        {
            return new StringVariable();
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [IdentifierVariable]
    /// </summary>
    public partial interface IStringVariable :
        IAVariable,
        ILoquiObjectSetter<IStringVariable>,
        IStringVariableGetter
    {
        new String Value { get; set; }
    }

    /// <summary>
    /// Implemented by: [IdentifierVariable]
    /// </summary>
    public partial interface IStringVariableGetter :
        IAVariableGetter,
        ILoquiObject<IStringVariableGetter>,
        IPexItem
    {
        static new ILoquiRegistration Registration => StringVariable_Registration.Instance;
        String Value { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class StringVariableMixIn
    {
        public static void Clear(this IStringVariable item)
        {
            ((StringVariableSetterCommon)((IStringVariableGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static StringVariable.Mask<bool> GetEqualsMask(
            this IStringVariableGetter item,
            IStringVariableGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IStringVariableGetter item,
            string? name = null,
            StringVariable.Mask<bool>? printMask = null)
        {
            return ((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IStringVariableGetter item,
            FileGeneration fg,
            string? name = null,
            StringVariable.Mask<bool>? printMask = null)
        {
            ((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IStringVariableGetter item,
            IStringVariableGetter rhs,
            StringVariable.TranslationMask? equalsMask = null)
        {
            return ((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IStringVariable lhs,
            IStringVariableGetter rhs,
            out StringVariable.ErrorMask errorMask,
            StringVariable.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((StringVariableSetterTranslationCommon)((IStringVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = StringVariable.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IStringVariable lhs,
            IStringVariableGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((StringVariableSetterTranslationCommon)((IStringVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static StringVariable DeepCopy(
            this IStringVariableGetter item,
            StringVariable.TranslationMask? copyMask = null)
        {
            return ((StringVariableSetterTranslationCommon)((IStringVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static StringVariable DeepCopy(
            this IStringVariableGetter item,
            out StringVariable.ErrorMask errorMask,
            StringVariable.TranslationMask? copyMask = null)
        {
            return ((StringVariableSetterTranslationCommon)((IStringVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static StringVariable DeepCopy(
            this IStringVariableGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((StringVariableSetterTranslationCommon)((IStringVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Pex Translation
        public static void CopyInFromBinary(
            this IStringVariable item,
            PexReader reader)
        {
            ((StringVariableSetterCommon)((IStringVariableGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum StringVariable_FieldIndex
    {
        Value = 0,
    }
    #endregion

    #region Registration
    public partial class StringVariable_Registration : ILoquiRegistration
    {
        public static readonly StringVariable_Registration Instance = new StringVariable_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_SkyrimPex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_SkyrimPex.ProtocolKey,
            msgID: 51,
            version: 0);

        public const string GUID = "f9c694de-74c0-4a64-a0c1-aacae5b4836c";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(StringVariable.Mask<>);

        public static readonly Type ErrorMaskType = typeof(StringVariable.ErrorMask);

        public static readonly Type ClassType = typeof(StringVariable);

        public static readonly Type GetterType = typeof(IStringVariableGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IStringVariable);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Pex.StringVariable";

        public const string Name = "StringVariable";

        public const string Namespace = "Mutagen.Bethesda.Skyrim.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type PexWriteTranslation = typeof(StringVariablePexWriteTranslation);
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
    public partial class StringVariableSetterCommon : AVariableSetterCommon
    {
        public new static readonly StringVariableSetterCommon Instance = new StringVariableSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IStringVariable item)
        {
            ClearPartial();
            item.Value = string.Empty;
            base.Clear(item);
        }
        
        public override void Clear(IAVariable item)
        {
            Clear(item: (IStringVariable)item);
        }
        
        #region Pex Translation
        public virtual void CopyInFromBinary(
            IStringVariable item,
            PexReader reader)
        {
            reader.EnsureVariableType(VariableType.String, VariableType.Identifier);
            item.Value = reader.ReadString();
        }
        
        public override void CopyInFromBinary(
            IAVariable item,
            PexReader reader)
        {
            CopyInFromBinary(
                item: (StringVariable)item,
                reader: reader);
        }
        
        #endregion
        
    }
    public partial class StringVariableCommon : AVariableCommon
    {
        public new static readonly StringVariableCommon Instance = new StringVariableCommon();

        public StringVariable.Mask<bool> GetEqualsMask(
            IStringVariableGetter item,
            IStringVariableGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new StringVariable.Mask<bool>(false);
            ((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IStringVariableGetter item,
            IStringVariableGetter rhs,
            StringVariable.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Value = string.Equals(item.Value, rhs.Value);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IStringVariableGetter item,
            string? name = null,
            StringVariable.Mask<bool>? printMask = null)
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
            IStringVariableGetter item,
            FileGeneration fg,
            string? name = null,
            StringVariable.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"StringVariable =>");
            }
            else
            {
                fg.AppendLine($"{name} (StringVariable) =>");
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
            IStringVariableGetter item,
            FileGeneration fg,
            StringVariable.Mask<bool>? printMask = null)
        {
            AVariableCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Value ?? true)
            {
                fg.AppendItem(item.Value, "Value");
            }
        }
        
        public static StringVariable_FieldIndex ConvertFieldIndex(AVariable_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IStringVariableGetter? lhs,
            IStringVariableGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IAVariableGetter)lhs, (IAVariableGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)StringVariable_FieldIndex.Value) ?? true))
            {
                if (!string.Equals(lhs.Value, rhs.Value)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAVariableGetter? lhs,
            IAVariableGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IStringVariableGetter?)lhs,
                rhs: rhs as IStringVariableGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IStringVariableGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Value);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAVariableGetter item)
        {
            return GetHashCode(item: (IStringVariableGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return StringVariable.GetNew();
        }
        
    }
    public partial class StringVariableSetterTranslationCommon : AVariableSetterTranslationCommon
    {
        public new static readonly StringVariableSetterTranslationCommon Instance = new StringVariableSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IStringVariable item,
            IStringVariableGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAVariable)item,
                (IAVariableGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)StringVariable_FieldIndex.Value) ?? true))
            {
                item.Value = rhs.Value;
            }
        }
        
        
        public override void DeepCopyIn(
            IAVariable item,
            IAVariableGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IStringVariable)item,
                rhs: (IStringVariableGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public StringVariable DeepCopy(
            IStringVariableGetter item,
            StringVariable.TranslationMask? copyMask = null)
        {
            StringVariable ret = (StringVariable)((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).GetNew();
            ((StringVariableSetterTranslationCommon)((IStringVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public StringVariable DeepCopy(
            IStringVariableGetter item,
            out StringVariable.ErrorMask errorMask,
            StringVariable.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            StringVariable ret = (StringVariable)((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).GetNew();
            ((StringVariableSetterTranslationCommon)((IStringVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = StringVariable.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public StringVariable DeepCopy(
            IStringVariableGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            StringVariable ret = (StringVariable)((StringVariableCommon)((IStringVariableGetter)item).CommonInstance()!).GetNew();
            ((StringVariableSetterTranslationCommon)((IStringVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class StringVariable
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => StringVariable_Registration.Instance;
        public new static StringVariable_Registration Registration => StringVariable_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => StringVariableCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return StringVariableSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => StringVariableSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Pex Translation
namespace Mutagen.Bethesda.Skyrim.Pex.Internals
{
    public partial class StringVariablePexWriteTranslation :
        AVariablePexWriteTranslation,
        IPexWriteTranslator
    {
        public new readonly static StringVariablePexWriteTranslation Instance = new StringVariablePexWriteTranslation();

        public virtual void Write(
            PexWriter writer,
            IStringVariableGetter item)
        {
            AVariablePexWriteTranslation.Instance.Write(
                item: item,
                writer: writer);
            writer.Write(item.Value);
        }

        public override void Write(
            PexWriter writer,
            object item)
        {
            Write(
                item: (IStringVariableGetter)item,
                writer: writer);
        }

        public override void Write(
            PexWriter writer,
            IAVariableGetter item)
        {
            Write(
                item: (IStringVariableGetter)item,
                writer: writer);
        }

    }

    public partial class StringVariablePexCreateTranslation : AVariablePexCreateTranslation
    {
        public new readonly static StringVariablePexCreateTranslation Instance = new StringVariablePexCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim.Pex
{
    #region Pex Write Mixins
    public static class StringVariablePexTranslationMixIn
    {
    }
    #endregion


}
#endregion

#endregion

