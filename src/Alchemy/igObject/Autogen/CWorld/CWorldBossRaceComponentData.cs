namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CWorldBossRaceComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CWaypoint? _playerPositionOutroCinematic;
        [FieldAttr(ctr: 24)] public EOctaneAdventureCutscene _adventureCutscene;
        [FieldAttr(ctr: 32)] public COxideBossData? _oxideBossData;
        [FieldAttr(ctr: 40)] public CEdcInfo? _outroCinematicInfo;
        [FieldAttr(ctr: 48)] public CSound? _outroCinematicMusic;
        [FieldAttr(ctr: 56)] public igEntityHandleList? _entitiesToHideDuringCutscene;
    }
}
