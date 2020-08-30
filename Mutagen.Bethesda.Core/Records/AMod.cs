using Mutagen.Bethesda.Persistance;
using System;
using Noggog;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Mutagen.Bethesda
{
    /// <summary> 
    /// An abstract base class for Mods to inherit from for some common functionality 
    /// </summary> 
    [DebuggerDisplay("{GameRelease} {ModKey.ToString()}")]
    public abstract class AMod : IMod
    {
        /// <summary> 
        /// The key associated with the mod 
        /// </summary> 
        public ModKey ModKey { get; }

        /// <summary> 
        /// The game release associated with the mod 
        /// </summary> 
        public abstract GameRelease GameRelease { get; }

        private readonly IFormKeyAllocator _allocator;

        protected AMod()
        {
            this.ModKey = ModKey.Null;
            this._allocator = new SimpleFormKeyAllocator(this);
        }

        /// <summary> 
        /// Constructor 
        /// </summary> 
        /// <param name="modKey">Key to assign the mod</param> 
        /// <param name="allocator">Optional custom FormKey allocator logic</param> 
        public AMod(ModKey modKey, IFormKeyAllocator? allocator = null)
        {
            this.ModKey = modKey;
            this._allocator = allocator ?? new SimpleFormKeyAllocator(this);
        }

        #region NonImplemented IMod 
        IEnumerable<FormKey> ILinkedFormKeyContainerGetter.LinkFormKeys => throw new NotImplementedException();
        void ILinkedFormKeyContainer.RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        IReadOnlyList<IMasterReferenceGetter> IModGetter.MasterReferences => throw new NotImplementedException();
        IList<MasterReference> IMod.MasterReferences => throw new NotImplementedException();
        uint IMod.NextFormID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public abstract bool CanUseLocalization { get; }
        public abstract bool UsingLocalization { get; set; }
        bool IModGetter.UsingLocalization => throw new NotImplementedException();
        ICache<T, FormKey> IMod.GetGroup<T>() => throw new NotImplementedException();
        public abstract void SyncRecordCount();
        IReadOnlyCache<T, FormKey> IModGetter.GetTopLevelGroupGetter<T>() => throw new NotImplementedException();
        void IModGetter.WriteToBinary(string path, BinaryWriteParameters? param) => throw new NotImplementedException();
        void IModGetter.WriteToBinaryParallel(string path, BinaryWriteParameters? param) => throw new NotImplementedException();
        IEnumerable<T> IMajorRecordEnumerable.EnumerateMajorRecords<T>() => throw new NotImplementedException();
        IEnumerable<IMajorRecordCommonGetter> IMajorRecordGetterEnumerable.EnumerateMajorRecords() => throw new NotImplementedException();
        IEnumerable<T> IMajorRecordGetterEnumerable.EnumerateMajorRecords<T>() => throw new NotImplementedException();
        IEnumerable<IMajorRecordCommonGetter> IMajorRecordGetterEnumerable.EnumerateMajorRecords(Type type, bool throwIfUnknown) => throw new NotImplementedException();
        IEnumerable<IMajorRecordCommon> IMajorRecordEnumerable.EnumerateMajorRecords() => throw new NotImplementedException();
        IEnumerable<IMajorRecordCommon> IMajorRecordEnumerable.EnumerateMajorRecords(Type t, bool throwIfUnknown) => throw new NotImplementedException();
        #endregion

        /// <summary> 
        /// Requests a new unused FormKey from the alloctor specified in the mod's construction 
        /// </summary> 
        /// <returns>An unused FormKey</returns> 
        public FormKey GetNextFormKey()
        {
            return _allocator.GetNextFormKey();
        }

        /// <summary> 
        /// Requests a new unused FormKey from the alloctor specified in the mod's construction 
        /// </summary> 
        /// <param name="editorID">The target EditorID that may potentially be used for synchronization</param> 
        /// <returns>An unused FormKey</returns> 
        public FormKey GetNextFormKey(string editorID)
        {
            return _allocator.GetNextFormKey(editorID);
        }
    }
}
