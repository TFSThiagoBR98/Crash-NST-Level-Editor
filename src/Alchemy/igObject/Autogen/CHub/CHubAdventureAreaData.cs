namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CHubAdventureAreaData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _areaName;
        [FieldAttr(ctr: 24)] public CWaypoint? _victoryPosition;
        [FieldAttr(ctr: 32)] public CWaypoint? _bossPosition;
        [FieldAttr(ctr: 40)] public CWaypoint? _cutsceneIntroBossPlayerPosition;
        [FieldAttr(ctr: 48)] public CPlayerStartEntity? _adventurePlayerStart;
        [FieldAttr(ctr: 56)] public EOctaneAdventureCutscene _adventureCutscene;
        [FieldAttr(ctr: 64)] public CEdcInfo? _edcInfo;
        [FieldAttr(ctr: 72)] public CSound? _edcMusic;
        [FieldAttr(ctr: 80)] public COctanePodiumComponentData? _podiumInfo;
        [FieldAttr(ctr: 88)] public CCutsceneUnlockDoorFactionHashTable? _cutsceneUnlockDoor;
        [FieldAttr(ctr: 96)] public CEntityList? _blinkingHubExitZones;
    }
}
