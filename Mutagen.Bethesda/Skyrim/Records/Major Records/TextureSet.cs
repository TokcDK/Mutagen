using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Mutagen.Bethesda.Skyrim
{
    public partial class TextureSet
    {
        #region Interfaces
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IObjectBoundsGetter IObjectBoundedGetter.ObjectBounds => this.ObjectBounds;
        #endregion

        [Flags]
        public enum Flag
        {
            NoSpecularMap = 0x01,
            FaceGenTextures = 0x02,
            HasModelSpaceNormalMap = 0x04,
        }
    }
}
