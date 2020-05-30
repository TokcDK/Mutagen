﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.Skyrim
{
    public interface IPlacedTrapTarget : IPlacedTrapTargetGetter, IMajorRecordCommon
    {
    }

    public interface IPlacedTrapTargetGetter : IMajorRecordCommonGetter
    {
    }
}
