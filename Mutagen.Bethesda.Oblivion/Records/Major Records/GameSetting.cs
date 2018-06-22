﻿using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Oblivion.Internals;
using Noggog.Notifying;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mutagen.Bethesda.Oblivion
{
    public partial class GameSetting
    {
        protected abstract char TriggerChar { get; }

        partial void CustomCtor()
        {
            this.EditorID_Property.Subscribe(CorrectEDID, cmds: NotifyingSubscribeParameters.NoFire);
        }

        private void CorrectEDID(Change<string> change)
        {
            if (change.New.Length == 0)
            {
                this.EditorID = string.Empty + this.TriggerChar;
            }
            else if (!this.TriggerChar.Equals(change.New[0]))
            {
                this.EditorID = this.TriggerChar + change.New;
            }
        }

        public static GameSetting Create_Binary(
            MutagenFrame frame,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            var initialPos = frame.Position;
            frame.Position += 20;
            if (!MajorRecord_Registration.EDID_HEADER.Equals(HeaderTranslation.GetNextSubRecordType(frame.Reader, out var edidLength)))
            {
                errorMask.ReportExceptionOrThrow(
                    new ArgumentException($"EDID was not located in expected position: {frame.Position}"));
                return null;
            }
            frame.Position += 6;
            if (!StringBinaryTranslation.Instance.Parse(
                frame.SpawnWithLength(edidLength),
                out var edid,
                errorMask))
            {
                errorMask.ReportExceptionOrThrow(
                    new ArgumentException($"EDID was parsed in expected position: {frame.Position}"));
                return null;
            }
            if (edid.Length == 0)
            {
                errorMask.ReportExceptionOrThrow(new ArgumentException("No EDID parsed."));
                return null;
            }
            frame.Position = initialPos;
            switch (edid[0])
            {
                case GameSettingInt.TRIGGER_CHAR:
                    return GameSettingInt.Create_Binary(frame, recordTypeConverter, errorMask);
                case GameSettingString.TRIGGER_CHAR:
                    return GameSettingString.Create_Binary(frame, recordTypeConverter, errorMask);
                case GameSettingFloat.TRIGGER_CHAR:
                    return GameSettingFloat.Create_Binary(frame, recordTypeConverter, errorMask);
                default:
                    errorMask.ReportExceptionOrThrow(new ArgumentException($"Unknown game setting type: {edid[0]}"));
                    return null;
            }
        }
    }
}
