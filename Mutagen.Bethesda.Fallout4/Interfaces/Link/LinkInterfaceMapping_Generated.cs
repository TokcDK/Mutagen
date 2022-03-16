/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Loqui;

namespace Mutagen.Bethesda.Fallout4.Internals
{
    public class LinkInterfaceMapping : ILinkInterfaceMapping
    {
        public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

        public GameCategory GameCategory => GameCategory.Fallout4;

        public LinkInterfaceMapping()
        {
            var dict = new Dictionary<Type, InterfaceMappingResult>();
            dict[typeof(IIdleRelation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                ActionRecord_Registration.Instance,
            });
            dict[typeof(IIdleRelationGetter)] = dict[typeof(IIdleRelation)] with { Setter = false };
            dict[typeof(IDamageTypeTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                ActorValueInformation_Registration.Instance,
            });
            dict[typeof(IDamageTypeTargetGetter)] = dict[typeof(IDamageTypeTarget)] with { Setter = false };
            dict[typeof(IObjectId)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Door_Registration.Instance,
                Faction_Registration.Instance,
                TextureSet_Registration.Instance,
            });
            dict[typeof(IObjectIdGetter)] = dict[typeof(IObjectId)] with { Setter = false };
            dict[typeof(ILocationTargetable)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Door_Registration.Instance,
            });
            dict[typeof(ILocationTargetableGetter)] = dict[typeof(ILocationTargetable)] with { Setter = false };
            dict[typeof(IOwner)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Faction_Registration.Instance,
            });
            dict[typeof(IOwnerGetter)] = dict[typeof(IOwner)] with { Setter = false };
            dict[typeof(IRelatable)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Faction_Registration.Instance,
                Race_Registration.Instance,
            });
            dict[typeof(IRelatableGetter)] = dict[typeof(IRelatable)] with { Setter = false };
            dict[typeof(IKeywordLinkedReference)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Keyword_Registration.Instance,
            });
            dict[typeof(IKeywordLinkedReferenceGetter)] = dict[typeof(IKeywordLinkedReference)] with { Setter = false };
            dict[typeof(IRegionTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                LandscapeTexture_Registration.Instance,
            });
            dict[typeof(IRegionTargetGetter)] = dict[typeof(IRegionTarget)] with { Setter = false };
            dict[typeof(ISpellRecord)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                LeveledSpell_Registration.Instance,
            });
            dict[typeof(ISpellRecordGetter)] = dict[typeof(ISpellRecord)] with { Setter = false };
            dict[typeof(ILocationRecord)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                LocationReferenceType_Registration.Instance,
            });
            dict[typeof(ILocationRecordGetter)] = dict[typeof(ILocationRecord)] with { Setter = false };
            InterfaceToObjectTypes = dict;
        }
    }
}

