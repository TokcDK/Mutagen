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
    public partial class AssignInstruction :
        Instruction,
        IAssignInstruction,
        IEquatable<IAssignInstructionGetter>,
        ILoquiObjectSetter<AssignInstruction>
    {
        #region Ctor
        public AssignInstruction()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Identifier
        public StringVariable Identifier { get; set; } = new StringVariable();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IStringVariableGetter IAssignInstructionGetter.Identifier => Identifier;
        #endregion
        #region Value
        public StringVariable Value { get; set; } = new StringVariable();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IStringVariableGetter IAssignInstructionGetter.Value => Value;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            AssignInstructionMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IAssignInstructionGetter rhs) return false;
            return ((AssignInstructionCommon)((IAssignInstructionGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IAssignInstructionGetter? obj)
        {
            return ((AssignInstructionCommon)((IAssignInstructionGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((AssignInstructionCommon)((IAssignInstructionGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            Instruction.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Identifier = new MaskItem<TItem, StringVariable.Mask<TItem>?>(initialValue, new StringVariable.Mask<TItem>(initialValue));
                this.Value = new MaskItem<TItem, StringVariable.Mask<TItem>?>(initialValue, new StringVariable.Mask<TItem>(initialValue));
            }

            public Mask(
                TItem Identifier,
                TItem Value)
            : base()
            {
                this.Identifier = new MaskItem<TItem, StringVariable.Mask<TItem>?>(Identifier, new StringVariable.Mask<TItem>(Identifier));
                this.Value = new MaskItem<TItem, StringVariable.Mask<TItem>?>(Value, new StringVariable.Mask<TItem>(Value));
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public MaskItem<TItem, StringVariable.Mask<TItem>?>? Identifier { get; set; }
            public MaskItem<TItem, StringVariable.Mask<TItem>?>? Value { get; set; }
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
                if (!object.Equals(this.Identifier, rhs.Identifier)) return false;
                if (!object.Equals(this.Value, rhs.Value)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Identifier);
                hash.Add(this.Value);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (Identifier != null)
                {
                    if (!eval(this.Identifier.Overall)) return false;
                    if (this.Identifier.Specific != null && !this.Identifier.Specific.All(eval)) return false;
                }
                if (Value != null)
                {
                    if (!eval(this.Value.Overall)) return false;
                    if (this.Value.Specific != null && !this.Value.Specific.All(eval)) return false;
                }
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (Identifier != null)
                {
                    if (eval(this.Identifier.Overall)) return true;
                    if (this.Identifier.Specific != null && this.Identifier.Specific.Any(eval)) return true;
                }
                if (Value != null)
                {
                    if (eval(this.Value.Overall)) return true;
                    if (this.Value.Specific != null && this.Value.Specific.Any(eval)) return true;
                }
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new AssignInstruction.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Identifier = this.Identifier == null ? null : new MaskItem<R, StringVariable.Mask<R>?>(eval(this.Identifier.Overall), this.Identifier.Specific?.Translate(eval));
                obj.Value = this.Value == null ? null : new MaskItem<R, StringVariable.Mask<R>?>(eval(this.Value.Overall), this.Value.Specific?.Translate(eval));
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(AssignInstruction.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, AssignInstruction.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(AssignInstruction.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Identifier?.Overall ?? true)
                    {
                        Identifier?.ToString(fg);
                    }
                    if (printMask?.Value?.Overall ?? true)
                    {
                        Value?.ToString(fg);
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            Instruction.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public MaskItem<Exception?, StringVariable.ErrorMask?>? Identifier;
            public MaskItem<Exception?, StringVariable.ErrorMask?>? Value;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                AssignInstruction_FieldIndex enu = (AssignInstruction_FieldIndex)index;
                switch (enu)
                {
                    case AssignInstruction_FieldIndex.Identifier:
                        return Identifier;
                    case AssignInstruction_FieldIndex.Value:
                        return Value;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                AssignInstruction_FieldIndex enu = (AssignInstruction_FieldIndex)index;
                switch (enu)
                {
                    case AssignInstruction_FieldIndex.Identifier:
                        this.Identifier = new MaskItem<Exception?, StringVariable.ErrorMask?>(ex, null);
                        break;
                    case AssignInstruction_FieldIndex.Value:
                        this.Value = new MaskItem<Exception?, StringVariable.ErrorMask?>(ex, null);
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                AssignInstruction_FieldIndex enu = (AssignInstruction_FieldIndex)index;
                switch (enu)
                {
                    case AssignInstruction_FieldIndex.Identifier:
                        this.Identifier = (MaskItem<Exception?, StringVariable.ErrorMask?>?)obj;
                        break;
                    case AssignInstruction_FieldIndex.Value:
                        this.Value = (MaskItem<Exception?, StringVariable.ErrorMask?>?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Identifier != null) return true;
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
                Identifier?.ToString(fg);
                Value?.ToString(fg);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Identifier = this.Identifier.Combine(rhs.Identifier, (l, r) => l.Combine(r));
                ret.Value = this.Value.Combine(rhs.Value, (l, r) => l.Combine(r));
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
            Instruction.TranslationMask,
            ITranslationMask
        {
            #region Members
            public StringVariable.TranslationMask? Identifier;
            public StringVariable.TranslationMask? Value;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Identifier != null ? Identifier.OnOverall : DefaultOn, Identifier?.GetCrystal()));
                ret.Add((Value != null ? Value.OnOverall : DefaultOn, Value?.GetCrystal()));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Pex Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object PexWriteTranslator => AssignInstructionPexWriteTranslation.Instance;
        void IPexItem.WriteToBinary(PexWriter writer)
        {
            ((AssignInstructionPexWriteTranslation)this.PexWriteTranslator).Write(
                item: this,
                writer: writer);
        }
        #region Pex Create
        public new static AssignInstruction CreateFromBinary(PexReader reader)
        {
            var ret = new AssignInstruction();
            ((AssignInstructionSetterCommon)((IAssignInstructionGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                reader: reader);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            PexReader reader,
            out AssignInstruction item)
        {
            var startPos = reader.Position;
            item = CreateFromBinary(reader: reader);
            return startPos != reader.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((AssignInstructionSetterCommon)((IAssignInstructionGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new AssignInstruction GetNew()
        {
            return new AssignInstruction();
        }

    }
    #endregion

    #region Interface
    public partial interface IAssignInstruction :
        IAssignInstructionGetter,
        IInstruction,
        ILoquiObjectSetter<IAssignInstruction>
    {
        new StringVariable Identifier { get; set; }
        new StringVariable Value { get; set; }
    }

    public partial interface IAssignInstructionGetter :
        IInstructionGetter,
        ILoquiObject<IAssignInstructionGetter>,
        IPexItem
    {
        static new ILoquiRegistration Registration => AssignInstruction_Registration.Instance;
        IStringVariableGetter Identifier { get; }
        IStringVariableGetter Value { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class AssignInstructionMixIn
    {
        public static void Clear(this IAssignInstruction item)
        {
            ((AssignInstructionSetterCommon)((IAssignInstructionGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static AssignInstruction.Mask<bool> GetEqualsMask(
            this IAssignInstructionGetter item,
            IAssignInstructionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IAssignInstructionGetter item,
            string? name = null,
            AssignInstruction.Mask<bool>? printMask = null)
        {
            return ((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IAssignInstructionGetter item,
            FileGeneration fg,
            string? name = null,
            AssignInstruction.Mask<bool>? printMask = null)
        {
            ((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IAssignInstructionGetter item,
            IAssignInstructionGetter rhs,
            AssignInstruction.TranslationMask? equalsMask = null)
        {
            return ((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IAssignInstruction lhs,
            IAssignInstructionGetter rhs,
            out AssignInstruction.ErrorMask errorMask,
            AssignInstruction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = AssignInstruction.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IAssignInstruction lhs,
            IAssignInstructionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static AssignInstruction DeepCopy(
            this IAssignInstructionGetter item,
            AssignInstruction.TranslationMask? copyMask = null)
        {
            return ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static AssignInstruction DeepCopy(
            this IAssignInstructionGetter item,
            out AssignInstruction.ErrorMask errorMask,
            AssignInstruction.TranslationMask? copyMask = null)
        {
            return ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static AssignInstruction DeepCopy(
            this IAssignInstructionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Pex Translation
        public static void CopyInFromBinary(
            this IAssignInstruction item,
            PexReader reader)
        {
            ((AssignInstructionSetterCommon)((IAssignInstructionGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum AssignInstruction_FieldIndex
    {
        Identifier = 0,
        Value = 1,
    }
    #endregion

    #region Registration
    public partial class AssignInstruction_Registration : ILoquiRegistration
    {
        public static readonly AssignInstruction_Registration Instance = new AssignInstruction_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_SkyrimPex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_SkyrimPex.ProtocolKey,
            msgID: 29,
            version: 0);

        public const string GUID = "48350445-04c2-47e1-820c-f453db09bf7e";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(AssignInstruction.Mask<>);

        public static readonly Type ErrorMaskType = typeof(AssignInstruction.ErrorMask);

        public static readonly Type ClassType = typeof(AssignInstruction);

        public static readonly Type GetterType = typeof(IAssignInstructionGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IAssignInstruction);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Pex.AssignInstruction";

        public const string Name = "AssignInstruction";

        public const string Namespace = "Mutagen.Bethesda.Skyrim.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type PexWriteTranslation = typeof(AssignInstructionPexWriteTranslation);
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
    public partial class AssignInstructionSetterCommon : InstructionSetterCommon
    {
        public new static readonly AssignInstructionSetterCommon Instance = new AssignInstructionSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IAssignInstruction item)
        {
            ClearPartial();
            item.Identifier.Clear();
            item.Value.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IInstruction item)
        {
            Clear(item: (IAssignInstruction)item);
        }
        
        #region Pex Translation
        public virtual void CopyInFromBinary(
            IAssignInstruction item,
            PexReader reader)
        {
            item.Identifier = Mutagen.Bethesda.Skyrim.Pex.StringVariable.CreateFromBinary(reader: reader);
            item.Value = Mutagen.Bethesda.Skyrim.Pex.StringVariable.CreateFromBinary(reader: reader);
        }
        
        public override void CopyInFromBinary(
            IInstruction item,
            PexReader reader)
        {
            CopyInFromBinary(
                item: (AssignInstruction)item,
                reader: reader);
        }
        
        #endregion
        
    }
    public partial class AssignInstructionCommon : InstructionCommon
    {
        public new static readonly AssignInstructionCommon Instance = new AssignInstructionCommon();

        public AssignInstruction.Mask<bool> GetEqualsMask(
            IAssignInstructionGetter item,
            IAssignInstructionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new AssignInstruction.Mask<bool>(false);
            ((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IAssignInstructionGetter item,
            IAssignInstructionGetter rhs,
            AssignInstruction.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Identifier = MaskItemExt.Factory(item.Identifier.GetEqualsMask(rhs.Identifier, include), include);
            ret.Value = MaskItemExt.Factory(item.Value.GetEqualsMask(rhs.Value, include), include);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IAssignInstructionGetter item,
            string? name = null,
            AssignInstruction.Mask<bool>? printMask = null)
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
            IAssignInstructionGetter item,
            FileGeneration fg,
            string? name = null,
            AssignInstruction.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"AssignInstruction =>");
            }
            else
            {
                fg.AppendLine($"{name} (AssignInstruction) =>");
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
            IAssignInstructionGetter item,
            FileGeneration fg,
            AssignInstruction.Mask<bool>? printMask = null)
        {
            InstructionCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Identifier?.Overall ?? true)
            {
                item.Identifier?.ToString(fg, "Identifier");
            }
            if (printMask?.Value?.Overall ?? true)
            {
                item.Value?.ToString(fg, "Value");
            }
        }
        
        public static AssignInstruction_FieldIndex ConvertFieldIndex(Instruction_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IAssignInstructionGetter? lhs,
            IAssignInstructionGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IInstructionGetter)lhs, (IInstructionGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Identifier) ?? true))
            {
                if (!object.Equals(lhs.Identifier, rhs.Identifier)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Value) ?? true))
            {
                if (!object.Equals(lhs.Value, rhs.Value)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IInstructionGetter? lhs,
            IInstructionGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IAssignInstructionGetter?)lhs,
                rhs: rhs as IAssignInstructionGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IAssignInstructionGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Identifier);
            hash.Add(item.Value);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IInstructionGetter item)
        {
            return GetHashCode(item: (IAssignInstructionGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return AssignInstruction.GetNew();
        }
        
    }
    public partial class AssignInstructionSetterTranslationCommon : InstructionSetterTranslationCommon
    {
        public new static readonly AssignInstructionSetterTranslationCommon Instance = new AssignInstructionSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IAssignInstruction item,
            IAssignInstructionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IInstruction)item,
                (IInstructionGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Identifier) ?? true))
            {
                errorMask?.PushIndex((int)AssignInstruction_FieldIndex.Identifier);
                try
                {
                    if ((copyMask?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Identifier) ?? true))
                    {
                        item.Identifier = rhs.Identifier.DeepCopy(
                            copyMask: copyMask?.GetSubCrystal((int)AssignInstruction_FieldIndex.Identifier),
                            errorMask: errorMask);
                    }
                }
                catch (Exception ex)
                when (errorMask != null)
                {
                    errorMask.ReportException(ex);
                }
                finally
                {
                    errorMask?.PopIndex();
                }
            }
            if ((copyMask?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Value) ?? true))
            {
                errorMask?.PushIndex((int)AssignInstruction_FieldIndex.Value);
                try
                {
                    if ((copyMask?.GetShouldTranslate((int)AssignInstruction_FieldIndex.Value) ?? true))
                    {
                        item.Value = rhs.Value.DeepCopy(
                            copyMask: copyMask?.GetSubCrystal((int)AssignInstruction_FieldIndex.Value),
                            errorMask: errorMask);
                    }
                }
                catch (Exception ex)
                when (errorMask != null)
                {
                    errorMask.ReportException(ex);
                }
                finally
                {
                    errorMask?.PopIndex();
                }
            }
        }
        
        
        public override void DeepCopyIn(
            IInstruction item,
            IInstructionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IAssignInstruction)item,
                rhs: (IAssignInstructionGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public AssignInstruction DeepCopy(
            IAssignInstructionGetter item,
            AssignInstruction.TranslationMask? copyMask = null)
        {
            AssignInstruction ret = (AssignInstruction)((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).GetNew();
            ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public AssignInstruction DeepCopy(
            IAssignInstructionGetter item,
            out AssignInstruction.ErrorMask errorMask,
            AssignInstruction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            AssignInstruction ret = (AssignInstruction)((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).GetNew();
            ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = AssignInstruction.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public AssignInstruction DeepCopy(
            IAssignInstructionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            AssignInstruction ret = (AssignInstruction)((AssignInstructionCommon)((IAssignInstructionGetter)item).CommonInstance()!).GetNew();
            ((AssignInstructionSetterTranslationCommon)((IAssignInstructionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class AssignInstruction
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => AssignInstruction_Registration.Instance;
        public new static AssignInstruction_Registration Registration => AssignInstruction_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => AssignInstructionCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return AssignInstructionSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => AssignInstructionSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Pex Translation
namespace Mutagen.Bethesda.Skyrim.Pex.Internals
{
    public partial class AssignInstructionPexWriteTranslation :
        InstructionPexWriteTranslation,
        IPexWriteTranslator
    {
        public new readonly static AssignInstructionPexWriteTranslation Instance = new AssignInstructionPexWriteTranslation();

        public void Write(
            PexWriter writer,
            IAssignInstructionGetter item)
        {
            InstructionPexWriteTranslation.Instance.Write(
                item: item,
                writer: writer);
            var IdentifierItem = item.Identifier;
            ((StringVariablePexWriteTranslation)((IPexItem)IdentifierItem).PexWriteTranslator).Write(
                item: IdentifierItem,
                writer: writer);
            var ValueItem = item.Value;
            ((StringVariablePexWriteTranslation)((IPexItem)ValueItem).PexWriteTranslator).Write(
                item: ValueItem,
                writer: writer);
        }

        public override void Write(
            PexWriter writer,
            object item)
        {
            Write(
                item: (IAssignInstructionGetter)item,
                writer: writer);
        }

        public override void Write(
            PexWriter writer,
            IInstructionGetter item)
        {
            Write(
                item: (IAssignInstructionGetter)item,
                writer: writer);
        }

    }

    public partial class AssignInstructionPexCreateTranslation : InstructionPexCreateTranslation
    {
        public new readonly static AssignInstructionPexCreateTranslation Instance = new AssignInstructionPexCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim.Pex
{
    #region Pex Write Mixins
    public static class AssignInstructionPexTranslationMixIn
    {
    }
    #endregion


}
#endregion

#endregion

