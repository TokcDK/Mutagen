﻿using Mutagen.Bethesda.Binary;
using Noggog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mutagen.Bethesda.Skyrim
{
    namespace Internals
    {
        public partial class PatrolBinaryCreateTranslation
        {
            static partial void FillBinaryPatrolScriptMarkerCustom(MutagenFrame frame, IPatrol item)
            {
                if (frame.ReadSubrecordFrame().Content.Length != 0)
                {
                    throw new ArgumentException($"Marker had unexpected length.");
                }
            }

            static partial void FillBinaryTopicsCustom(MutagenFrame frame, IPatrol item)
            {
                item.Topics.SetTo(ATopicReferenceBinaryCreateTranslation.Factory(frame));
            }
        }

        public partial class PatrolBinaryWriteTranslation
        {
            static partial void WriteBinaryPatrolScriptMarkerCustom(MutagenWriter writer, IPatrolGetter item)
            {
                using (HeaderExport.ExportSubrecordHeader(writer, Patrol_Registration.XPPA_HEADER)) { }
            }

            static partial void WriteBinaryTopicsCustom(MutagenWriter writer, IPatrolGetter item)
            {
                ATopicReferenceBinaryWriteTranslation.Write(writer, item.Topics);
            }
        }

        public partial class PatrolBinaryOverlay
        {
            public IReadOnlyList<IATopicReferenceGetter> Topics => throw new NotImplementedException();

            partial void PatrolScriptMarkerCustomParse(BinaryMemoryReadStream stream, int offset)
            {
                throw new NotImplementedException();
            }

            partial void TopicsCustomParse(
                BinaryMemoryReadStream stream,
                long finalPos,
                int offset,
                RecordType type,
                int? lastParsed)
            {
                throw new NotImplementedException();
            }
        }
    }
}
