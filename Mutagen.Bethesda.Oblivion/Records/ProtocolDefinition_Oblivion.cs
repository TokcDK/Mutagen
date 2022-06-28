using Mutagen.Bethesda.Oblivion;

namespace Loqui;

internal class ProtocolDefinition_Oblivion : IProtocolRegistration
{
    public static readonly ProtocolKey ProtocolKey = new("Oblivion");
    void IProtocolRegistration.Register() => Register();
    public static void Register()
    {
        LoquiRegistration.Register(
            ModStats_Registration.Instance,
            OblivionModHeader_Registration.Instance,
            OblivionMod_Registration.Instance,
            GameSetting_Registration.Instance,
            GameSettingInt_Registration.Instance,
            GameSettingFloat_Registration.Instance,
            GameSettingString_Registration.Instance,
            Global_Registration.Instance,
            GlobalInt_Registration.Instance,
            GlobalShort_Registration.Instance,
            GlobalFloat_Registration.Instance,
            Class_Registration.Instance,
            ClassTraining_Registration.Instance,
            Model_Registration.Instance,
            Hair_Registration.Instance,
            Faction_Registration.Instance,
            Relation_Registration.Instance,
            Rank_Registration.Instance,
            Race_Registration.Instance,
            SkillBoost_Registration.Instance,
            SpellUnleveled_Registration.Instance,
            Eye_Registration.Instance,
            RaceStats_Registration.Instance,
            FacePart_Registration.Instance,
            BodyData_Registration.Instance,
            BodyPart_Registration.Instance,
            FaceGenData_Registration.Instance,
            Sound_Registration.Instance,
            SoundData_Registration.Instance,
            SoundDataExtended_Registration.Instance,
            SkillRecord_Registration.Instance,
            MagicEffect_Registration.Instance,
            Script_Registration.Instance,
            ScriptMetaSummary_Registration.Instance,
            LocalVariable_Registration.Instance,
            AScriptReference_Registration.Instance,
            LandTexture_Registration.Instance,
            HavokData_Registration.Instance,
            Effect_Registration.Instance,
            ScriptEffect_Registration.Instance,
            Enchantment_Registration.Instance,
            MagicEffectSubData_Registration.Instance,
            EffectShader_Registration.Instance,
            Grass_Registration.Instance,
            Light_Registration.Instance,
            ScriptVariableReference_Registration.Instance,
            ScriptObjectReference_Registration.Instance,
            Birthsign_Registration.Instance,
            Spell_Registration.Instance,
            SpellLeveled_Registration.Instance,
            Activator_Registration.Instance,
            AlchemicalApparatus_Registration.Instance,
            Armor_Registration.Instance,
            Book_Registration.Instance,
            Clothing_Registration.Instance,
            Container_Registration.Instance,
            ContainerItem_Registration.Instance,
            Door_Registration.Instance,
            Worldspace_Registration.Instance,
            Ingredient_Registration.Instance,
            Miscellaneous_Registration.Instance,
            Static_Registration.Instance,
            Tree_Registration.Instance,
            Flora_Registration.Instance,
            Furniture_Registration.Instance,
            Weapon_Registration.Instance,
            Ammunition_Registration.Instance,
            Npc_Registration.Instance,
            RankPlacement_Registration.Instance,
            ItemEntry_Registration.Instance,
            AIPackage_Registration.Instance,
            CombatStyle_Registration.Instance,
            Creature_Registration.Instance,
            CreatureSound_Registration.Instance,
            SoundItem_Registration.Instance,
            LeveledCreature_Registration.Instance,
            SoulGem_Registration.Instance,
            Key_Registration.Instance,
            Potion_Registration.Instance,
            Subspace_Registration.Instance,
            SigilStone_Registration.Instance,
            LeveledItem_Registration.Instance,
            Weather_Registration.Instance,
            WeatherColors_Registration.Instance,
            WeatherSound_Registration.Instance,
            Climate_Registration.Instance,
            WeatherType_Registration.Instance,
            Region_Registration.Instance,
            RegionArea_Registration.Instance,
            RegionData_Registration.Instance,
            RegionObjects_Registration.Instance,
            RegionMap_Registration.Instance,
            RegionGrasses_Registration.Instance,
            RegionSounds_Registration.Instance,
            RegionWeather_Registration.Instance,
            RegionObject_Registration.Instance,
            RegionSound_Registration.Instance,
            Cell_Registration.Instance,
            PlacedObject_Registration.Instance,
            TeleportDestination_Registration.Instance,
            LockInformation_Registration.Instance,
            EnableParent_Registration.Instance,
            DistantLODData_Registration.Instance,
            MapMarker_Registration.Instance,
            Water_Registration.Instance,
            PlacedCreature_Registration.Instance,
            PathGrid_Registration.Instance,
            PathGridPoint_Registration.Instance,
            CellBlock_Registration.Instance,
            CellSubBlock_Registration.Instance,
            InterCellPoint_Registration.Instance,
            PointToReferenceMapping_Registration.Instance,
            PlacedNpc_Registration.Instance,
            CellLighting_Registration.Instance,
            Road_Registration.Instance,
            WorldspaceBlock_Registration.Instance,
            WorldspaceSubBlock_Registration.Instance,
            RoadPoint_Registration.Instance,
            Landscape_Registration.Instance,
            AlphaLayer_Registration.Instance,
            BaseLayer_Registration.Instance,
            MapData_Registration.Instance,
            DialogTopic_Registration.Instance,
            Quest_Registration.Instance,
            DialogItem_Registration.Instance,
            DialogResponse_Registration.Instance,
            Condition_Registration.Instance,
            ScriptFields_Registration.Instance,
            LogEntry_Registration.Instance,
            QuestTarget_Registration.Instance,
            QuestStage_Registration.Instance,
            IdleAnimation_Registration.Instance,
            AIPackageLocation_Registration.Instance,
            AIPackageSchedule_Registration.Instance,
            AIPackageTarget_Registration.Instance,
            CombatStyleAdvanced_Registration.Instance,
            LoadScreen_Registration.Instance,
            LoadScreenLocation_Registration.Instance,
            LeveledSpell_Registration.Instance,
            AnimatedObject_Registration.Instance,
            RelatedWaters_Registration.Instance,
            RaceRelation_Registration.Instance,
            OblivionMajorRecord_Registration.Instance,
            OblivionGroup_Registration.Instance,
            OblivionListGroup_Registration.Instance,
            ClothingFlags_Registration.Instance,
            AIPackageData_Registration.Instance,
            AlchemicalApparatusData_Registration.Instance,
            AmmunitionData_Registration.Instance,
            ArmorData_Registration.Instance,
            BookData_Registration.Instance,
            ClassData_Registration.Instance,
            ClimateData_Registration.Instance,
            ClothingData_Registration.Instance,
            CombatStyleData_Registration.Instance,
            ContainerData_Registration.Instance,
            CreatureConfiguration_Registration.Instance,
            CreatureAIData_Registration.Instance,
            CreatureData_Registration.Instance,
            DialogItemData_Registration.Instance,
            DialogResponseData_Registration.Instance,
            EffectShaderData_Registration.Instance,
            EnchantmentData_Registration.Instance,
            SeasonalIngredientProduction_Registration.Instance,
            GrassData_Registration.Instance,
            IngredientData_Registration.Instance,
            KeyData_Registration.Instance,
            LayerHeader_Registration.Instance,
            LightData_Registration.Instance,
            MagicEffectData_Registration.Instance,
            MiscellaneousData_Registration.Instance,
            NpcConfiguration_Registration.Instance,
            AIData_Registration.Instance,
            NpcData_Registration.Instance,
            Location_Registration.Instance,
            PotionData_Registration.Instance,
            QuestTargetData_Registration.Instance,
            QuestData_Registration.Instance,
            RaceData_Registration.Instance,
            RegionDataHeader_Registration.Instance,
            LocalVariableData_Registration.Instance,
            SigilStoneData_Registration.Instance,
            SkillData_Registration.Instance,
            SoulGemData_Registration.Instance,
            SpellData_Registration.Instance,
            TreeData_Registration.Instance,
            Dimensions_Registration.Instance,
            WaterData_Registration.Instance,
            WeaponData_Registration.Instance,
            FogDistance_Registration.Instance,
            HDRData_Registration.Instance,
            WeatherData_Registration.Instance,
            EffectData_Registration.Instance,
            ScriptEffectData_Registration.Instance,
            LeveledCreatureEntry_Registration.Instance,
            LeveledItemEntry_Registration.Instance,
            LeveledSpellEntry_Registration.Instance
        );
    }
}
