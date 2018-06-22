/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loqui;
using Noggog;
using Noggog.Notifying;
using Mutagen.Bethesda.Oblivion.Internals;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Internals;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Noggog.Xml;
using Loqui.Xml;
using Loqui.Internal;
using System.Diagnostics;
using Loqui.Internal;
using System.Collections.Specialized;
using Mutagen.Bethesda.Binary;

namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public abstract partial class Spell : 
        NamedMajorRecord,
        ISpell,
        ILoquiObject<Spell>,
        ILoquiObjectSetter,
        IEquatable<Spell>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Spell_Registration.Instance;
        public new static Spell_Registration Registration => Spell_Registration.Instance;

        #region Ctor
        public Spell()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region Loqui Getter Interface

        protected override object GetNthObject(ushort index) => SpellCommon.GetNthObject(index, this);

        protected override bool GetNthObjectHasBeenSet(ushort index) => SpellCommon.GetNthObjectHasBeenSet(index, this);

        protected override void UnsetNthObject(ushort index, NotifyingUnsetParameters cmds) => SpellCommon.UnsetNthObject(index, this, cmds);

        #endregion

        #region Loqui Interface
        protected override void SetNthObjectHasBeenSet(ushort index, bool on)
        {
            SpellCommon.SetNthObjectHasBeenSet(index, on, this);
        }

        #endregion

        IMask<bool> IEqualsMask<Spell>.GetEqualsMask(Spell rhs) => SpellCommon.GetEqualsMask(this, rhs);
        IMask<bool> IEqualsMask<ISpellGetter>.GetEqualsMask(ISpellGetter rhs) => SpellCommon.GetEqualsMask(this, rhs);
        #region To String
        public override string ToString()
        {
            return SpellCommon.ToString(this, printMask: null);
        }

        public string ToString(
            string name = null,
            Spell_Mask<bool> printMask = null)
        {
            return SpellCommon.ToString(this, name: name, printMask: printMask);
        }

        public override void ToString(
            FileGeneration fg,
            string name = null)
        {
            SpellCommon.ToString(this, fg, name: name, printMask: null);
        }

        #endregion

        IMask<bool> ILoquiObjectGetter.GetHasBeenSetMask() => this.GetHasBeenSetMask();
        public new Spell_Mask<bool> GetHasBeenSetMask()
        {
            return SpellCommon.GetHasBeenSetMask(this);
        }
        #region Equals and Hash
        public override bool Equals(object obj)
        {
            if (!(obj is Spell rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(Spell rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion


        #region XML Translation
        #region XML Copy In
        public override void CopyIn_XML(
            XElement root,
            NotifyingFireParameters cmds = null)
        {
            LoquiXmlTranslation<Spell>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: null,
                cmds: cmds);
        }

        public virtual void CopyIn_XML(
            XElement root,
            out Spell_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = new ErrorMaskBuilder();
            LoquiXmlTranslation<Spell>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: errorMaskBuilder,
                cmds: cmds);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyIn_XML(
            string path,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            string path,
            out Spell_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_XML(
            Stream stream,
            out Spell_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_XML(
                root: root,
                errorMask: out errorMask,
                cmds: cmds);
        }

        public override void CopyIn_XML(
            XElement root,
            out NamedMajorRecord_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            this.CopyIn_XML(
                root: root,
                errorMask: out Spell_ErrorMask errMask,
                cmds: cmds);
            errorMask = errMask;
        }

        public override void CopyIn_XML(
            XElement root,
            out MajorRecord_ErrorMask errorMask,
            NotifyingFireParameters cmds = null)
        {
            this.CopyIn_XML(
                root: root,
                errorMask: out Spell_ErrorMask errMask,
                cmds: cmds);
            errorMask = errMask;
        }

        #endregion

        #region XML Write
        public virtual void Write_XML(
            XElement node,
            out Spell_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_XML_Internal(
                node: node,
                name: name,
                errorMask: errorMaskBuilder);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_XML(
            string path,
            out Spell_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_XML(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks);
            topNode.Elements().First().Save(path);
        }

        public virtual void Write_XML(
            Stream stream,
            out Spell_ErrorMask errorMask,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_XML(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks);
            topNode.Elements().First().Save(stream);
        }

        protected override void Write_XML_Internal(
            XElement node,
            ErrorMaskBuilder errorMask,
            string name = null)
        {
            SpellCommon.Write_XML(
                item: this,
                node: node,
                name: name,
                errorMask: errorMask);
        }
        #endregion

        protected static void Fill_XML_Internal(
            Spell item,
            XElement root,
            string name,
            ErrorMaskBuilder errorMask)
        {
            switch (name)
            {
                default:
                    NamedMajorRecord.Fill_XML_Internal(
                        item: item,
                        root: root,
                        name: name,
                        errorMask: errorMask);
                    break;
            }
        }

        #endregion

        #region Binary Translation
        #region Binary Write
        public virtual void Write_Binary(
            MutagenWriter writer,
            out Spell_ErrorMask errorMask,
            bool doMasks = true)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Binary_Internal(
                writer: writer,
                recordTypeConverter: null,
                errorMask: errorMaskBuilder);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_Binary(
            string path,
            out Spell_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(path))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        public virtual void Write_Binary(
            Stream stream,
            out Spell_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(stream))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        protected override void Write_Binary_Internal(
            MutagenWriter writer,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            SpellCommon.Write_Binary(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask);
        }
        #endregion

        #endregion

        public Spell Copy(
            Spell_CopyMask copyMask = null,
            ISpellGetter def = null)
        {
            return Spell.Copy(
                this,
                copyMask: copyMask,
                def: def);
        }

        public static Spell Copy(
            ISpell item,
            Spell_CopyMask copyMask = null,
            ISpellGetter def = null)
        {
            Spell ret = (Spell)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public static Spell Copy_ToLoqui(
            ISpellGetter item,
            Spell_CopyMask copyMask = null,
            ISpellGetter def = null)
        {
            Spell ret = (Spell)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public void CopyFieldsFrom(
            ISpellGetter rhs,
            Spell_CopyMask copyMask,
            ISpellGetter def = null,
            NotifyingFireParameters cmds = null)
        {
            this.CopyFieldsFrom(
                rhs: rhs,
                def: def,
                doMasks: false,
                errorMask: out var errMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        public void CopyFieldsFrom(
            ISpellGetter rhs,
            out Spell_ErrorMask errorMask,
            Spell_CopyMask copyMask = null,
            ISpellGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            SpellCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMaskBuilder,
                copyMask: copyMask,
                cmds: cmds);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyFieldsFrom(
            ISpellGetter rhs,
            ErrorMaskBuilder errorMask,
            Spell_CopyMask copyMask = null,
            ISpellGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            SpellCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        protected override void SetNthObject(ushort index, object obj, NotifyingFireParameters cmds = null)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthObject(index, obj, cmds);
                    break;
            }
        }

        public override void Clear(NotifyingUnsetParameters cmds = null)
        {
            CallClearPartial_Internal(cmds);
            SpellCommon.Clear(this, cmds);
        }


        protected new static void CopyInInternal_Spell(Spell obj, KeyValuePair<ushort, object> pair)
        {
            if (!EnumExt.TryParse(pair.Key, out Spell_FieldIndex enu))
            {
                CopyInInternal_NamedMajorRecord(obj, pair);
            }
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Unknown enum type: {enu}");
            }
        }
        public static void CopyIn(IEnumerable<KeyValuePair<ushort, object>> fields, Spell obj)
        {
            ILoquiObjectExt.CopyFieldsIn(obj, fields, def: null, skipProtected: false, cmds: null);
        }

    }
    #endregion

    #region Interface
    public partial interface ISpell : ISpellGetter, INamedMajorRecord, ILoquiClass<ISpell, ISpellGetter>, ILoquiClass<Spell, ISpellGetter>
    {
    }

    public partial interface ISpellGetter : INamedMajorRecordGetter
    {

    }

    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum Spell_FieldIndex
    {
        MajorRecordFlags = 0,
        FormID = 1,
        Version = 2,
        EditorID = 3,
        RecordType = 4,
        Name = 5,
    }
    #endregion

    #region Registration
    public class Spell_Registration : ILoquiRegistration
    {
        public static readonly Spell_Registration Instance = new Spell_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 63,
            version: 0);

        public const string GUID = "44825ec2-b86b-4bd0-9d30-06761a7db25c";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 6;

        public static readonly Type MaskType = typeof(Spell_Mask<>);

        public static readonly Type ErrorMaskType = typeof(Spell_ErrorMask);

        public static readonly Type ClassType = typeof(Spell);

        public static readonly Type GetterType = typeof(ISpellGetter);

        public static readonly Type SetterType = typeof(ISpell);

        public static readonly Type CommonType = typeof(SpellCommon);

        public const string FullName = "Mutagen.Bethesda.Oblivion.Spell";

        public const string Name = "Spell";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type GenericRegistrationType = null;

        public static ushort? GetNameIndex(StringCaseAgnostic str)
        {
            switch (str.Upper)
            {
                default:
                    return null;
            }
        }

        public static bool GetNthIsEnumerable(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.GetNthIsEnumerable(index);
            }
        }

        public static bool GetNthIsLoqui(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.GetNthIsLoqui(index);
            }
        }

        public static bool GetNthIsSingleton(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.GetNthIsSingleton(index);
            }
        }

        public static string GetNthName(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.GetNthName(index);
            }
        }

        public static bool IsNthDerivative(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.IsNthDerivative(index);
            }
        }

        public static bool IsProtected(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.IsProtected(index);
            }
        }

        public static Type GetNthType(ushort index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecord_Registration.GetNthType(index);
            }
        }

        public static readonly RecordType FULL_HEADER = new RecordType("FULL");
        public static readonly RecordType LVSP_HEADER = new RecordType("LVSP");
        public static readonly RecordType SPEL_HEADER = new RecordType("SPEL");
        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        FULL_HEADER,
                        LVSP_HEADER,
                        SPEL_HEADER
                    })
            );
        });
        public const int NumStructFields = 0;
        public const int NumTypedFields = 0;
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
        Type ILoquiRegistration.GetterType => GetterType;
        Type ILoquiRegistration.CommonType => CommonType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => GetNameIndex(name);
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => GetNthIsEnumerable(index);
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => GetNthIsLoqui(index);
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => GetNthIsSingleton(index);
        string ILoquiRegistration.GetNthName(ushort index) => GetNthName(index);
        bool ILoquiRegistration.IsNthDerivative(ushort index) => IsNthDerivative(index);
        bool ILoquiRegistration.IsProtected(ushort index) => IsProtected(index);
        Type ILoquiRegistration.GetNthType(ushort index) => GetNthType(index);
        #endregion

    }
    #endregion

    #region Extensions
    public static partial class SpellCommon
    {
        #region Copy Fields From
        public static void CopyFieldsFrom(
            ISpell item,
            ISpellGetter rhs,
            ISpellGetter def,
            ErrorMaskBuilder errorMask,
            Spell_CopyMask copyMask,
            NotifyingFireParameters cmds = null)
        {
            NamedMajorRecordCommon.CopyFieldsFrom(
                item,
                rhs,
                def,
                errorMask,
                copyMask,
                cmds);
        }

        #endregion

        public static void SetNthObjectHasBeenSet(
            ushort index,
            bool on,
            ISpell obj,
            NotifyingFireParameters cmds = null)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    NamedMajorRecordCommon.SetNthObjectHasBeenSet(index, on, obj);
                    break;
            }
        }

        public static void UnsetNthObject(
            ushort index,
            ISpell obj,
            NotifyingUnsetParameters cmds = null)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    NamedMajorRecordCommon.UnsetNthObject(index, obj);
                    break;
            }
        }

        public static bool GetNthObjectHasBeenSet(
            ushort index,
            ISpell obj)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecordCommon.GetNthObjectHasBeenSet(index, obj);
            }
        }

        public static object GetNthObject(
            ushort index,
            ISpellGetter obj)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return NamedMajorRecordCommon.GetNthObject(index, obj);
            }
        }

        public static void Clear(
            ISpell item,
            NotifyingUnsetParameters cmds = null)
        {
        }

        public static Spell_Mask<bool> GetEqualsMask(
            this ISpellGetter item,
            ISpellGetter rhs)
        {
            var ret = new Spell_Mask<bool>();
            FillEqualsMask(item, rhs, ret);
            return ret;
        }

        public static void FillEqualsMask(
            ISpellGetter item,
            ISpellGetter rhs,
            Spell_Mask<bool> ret)
        {
            if (rhs == null) return;
            NamedMajorRecordCommon.FillEqualsMask(item, rhs, ret);
        }

        public static string ToString(
            this ISpellGetter item,
            string name = null,
            Spell_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            item.ToString(fg, name, printMask);
            return fg.ToString();
        }

        public static void ToString(
            this ISpellGetter item,
            FileGeneration fg,
            string name = null,
            Spell_Mask<bool> printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"{nameof(Spell)} =>");
            }
            else
            {
                fg.AppendLine($"{name} ({nameof(Spell)}) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }

        public static bool HasBeenSet(
            this ISpellGetter item,
            Spell_Mask<bool?> checkMask)
        {
            return true;
        }

        public static Spell_Mask<bool> GetHasBeenSetMask(ISpellGetter item)
        {
            var ret = new Spell_Mask<bool>();
            return ret;
        }

        public static Spell_FieldIndex? ConvertFieldIndex(NamedMajorRecord_FieldIndex? index)
        {
            if (!index.HasValue) return null;
            return ConvertFieldIndex(index: index.Value);
        }

        public static Spell_FieldIndex ConvertFieldIndex(NamedMajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case NamedMajorRecord_FieldIndex.MajorRecordFlags:
                    return (Spell_FieldIndex)((int)index);
                case NamedMajorRecord_FieldIndex.FormID:
                    return (Spell_FieldIndex)((int)index);
                case NamedMajorRecord_FieldIndex.Version:
                    return (Spell_FieldIndex)((int)index);
                case NamedMajorRecord_FieldIndex.EditorID:
                    return (Spell_FieldIndex)((int)index);
                case NamedMajorRecord_FieldIndex.RecordType:
                    return (Spell_FieldIndex)((int)index);
                case NamedMajorRecord_FieldIndex.Name:
                    return (Spell_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }

        public static Spell_FieldIndex? ConvertFieldIndex(MajorRecord_FieldIndex? index)
        {
            if (!index.HasValue) return null;
            return ConvertFieldIndex(index: index.Value);
        }

        public static Spell_FieldIndex ConvertFieldIndex(MajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case MajorRecord_FieldIndex.MajorRecordFlags:
                    return (Spell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.FormID:
                    return (Spell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.Version:
                    return (Spell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.EditorID:
                    return (Spell_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.RecordType:
                    return (Spell_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }

        #region XML Translation
        #region XML Write
        public static void Write_XML(
            XElement node,
            ISpellGetter item,
            bool doMasks,
            out Spell_ErrorMask errorMask,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_XML(
                node: node,
                name: name,
                item: item,
                errorMask: errorMaskBuilder);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_XML(
            XElement node,
            ISpellGetter item,
            ErrorMaskBuilder errorMask,
            string name = null)
        {
            var elem = new XElement(name ?? "Mutagen.Bethesda.Oblivion.Spell");
            node.Add(elem);
            if (name != null)
            {
                elem.SetAttributeValue("type", "Mutagen.Bethesda.Oblivion.Spell");
            }
        }
        #endregion

        #endregion

        #region Binary Translation
        #region Binary Write
        public static void Write_Binary(
            MutagenWriter writer,
            Spell item,
            RecordTypeConverter recordTypeConverter,
            bool doMasks,
            out Spell_ErrorMask errorMask)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Binary(
                writer: writer,
                item: item,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMaskBuilder);
            errorMask = Spell_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_Binary(
            MutagenWriter writer,
            Spell item,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            MajorRecordCommon.Write_Binary_Embedded(
                item: item,
                writer: writer,
                errorMask: errorMask);
            NamedMajorRecordCommon.Write_Binary_RecordTypes(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask);
        }
        #endregion

        #endregion

    }
    #endregion

    #region Modules

    #region Mask
    public class Spell_Mask<T> : NamedMajorRecord_Mask<T>, IMask<T>, IEquatable<Spell_Mask<T>>
    {
        #region Ctors
        public Spell_Mask()
        {
        }

        public Spell_Mask(T initialValue)
        {
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            if (!(obj is Spell_Mask<T> rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(Spell_Mask<T> rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion

        #region All Equal
        public override bool AllEqual(Func<T, bool> eval)
        {
            if (!base.AllEqual(eval)) return false;
            return true;
        }
        #endregion

        #region Translate
        public new Spell_Mask<R> Translate<R>(Func<T, R> eval)
        {
            var ret = new Spell_Mask<R>();
            this.Translate_InternalFill(ret, eval);
            return ret;
        }

        protected void Translate_InternalFill<R>(Spell_Mask<R> obj, Func<T, R> eval)
        {
            base.Translate_InternalFill(obj, eval);
        }
        #endregion

        #region Clear Enumerables
        public override void ClearEnumerables()
        {
            base.ClearEnumerables();
        }
        #endregion

        #region To String
        public override string ToString()
        {
            return ToString(printMask: null);
        }

        public string ToString(Spell_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            ToString(fg, printMask);
            return fg.ToString();
        }

        public void ToString(FileGeneration fg, Spell_Mask<bool> printMask = null)
        {
            fg.AppendLine($"{nameof(Spell_Mask<T>)} =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }
        #endregion

    }

    public class Spell_ErrorMask : NamedMajorRecord_ErrorMask, IErrorMask<Spell_ErrorMask>
    {
        #region IErrorMask
        public override object GetNthMask(int index)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    return base.GetNthMask(index);
            }
        }

        public override void SetNthException(int index, Exception ex)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthException(index, ex);
                    break;
            }
        }

        public override void SetNthMask(int index, object obj)
        {
            Spell_FieldIndex enu = (Spell_FieldIndex)index;
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
            ToString(fg);
            return fg.ToString();
        }

        public override void ToString(FileGeneration fg)
        {
            fg.AppendLine("Spell_ErrorMask =>");
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
        public Spell_ErrorMask Combine(Spell_ErrorMask rhs)
        {
            var ret = new Spell_ErrorMask();
            return ret;
        }
        public static Spell_ErrorMask Combine(Spell_ErrorMask lhs, Spell_ErrorMask rhs)
        {
            if (lhs != null && rhs != null) return lhs.Combine(rhs);
            return lhs ?? rhs;
        }
        #endregion

        #region Factory
        public static Spell_ErrorMask Factory(ErrorMaskBuilder errorMask)
        {
            if (errorMask?.Empty ?? true) return null;
            return new Spell_ErrorMask();
        }
        #endregion

    }
    public class Spell_CopyMask : NamedMajorRecord_CopyMask
    {
    }
    #endregion





    #endregion

}
