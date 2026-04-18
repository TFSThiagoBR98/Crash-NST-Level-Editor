namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CWorldHUBComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CHUBZoneList? _hubZones;
        [FieldAttr(ctr: 24)] public CHUBHintHashTable? _hubHintsList;
        [FieldAttr(ctr: 32)] public CHubCollectibleHashTable? _collectibleDataList;
        [FieldAttr(ctr: 40)] public CHubRequirementVfxHashTable? _requirementVfxList;
        [FieldAttr(ctr: 48)] public igVfxEffect? _hubTeleporterVfx;
        [FieldAttr(ctr: 56)] public CCutsceneCamera? _hintCutsceneCamera;
        [FieldAttr(ctr: 64)] public CEdcInfo? _finalBossCutsceneIntro;
        [FieldAttr(ctr: 72)] public CSound? _finalBossCutsceneIntroMusic;
        [FieldAttr(ctr: 80)] public EOctaneAdventureCutscene _finalBossAdventureCutscene;
        [FieldAttr(ctr: 88)] public CHubAdventureAreaDataHashTable? _adventureAreaData;
        [FieldAttr(ctr: 96)] public string? _introMovieName;
    }
}
