namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 8)]
    public class CWorldRaceSystemComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public int _maximumNumberOfRacers;
        [FieldAttr(ctr: 20)] public bool _debug;
        [FieldAttr(ctr: 24)] public string? _ttrStatsFileName;
        [FieldAttr(ctr: 32)] public string? _bossTtrStatsFileName;
        [FieldAttr(ctr: 40)] public CLapTTRData? _positionTTR;
        [FieldAttr(ctr: 48)] public CLapTTRData? _rubberbandOffset;
        [FieldAttr(ctr: 56)] public CGameModeTTRTable? _gameModeTTR;
        [FieldAttr(ctr: 64)] public igHandleMetaField _bossDriver = new();
        [FieldAttr(ctr: 72)] public igComponentDataTable? _bossExtraComponents;
        [FieldAttr(ctr: 80)] public CBossPowerUpRubberbandDataList? _playerPowerUpsInBoss;
        [FieldAttr(ctr: 88)] public CDifficultySpecificFloat? _bossBoostSuccessChance;
        [FieldAttr(ctr: 96)] public float _aiStartingLookaheadOffset;
        [FieldAttr(ctr: 100)] public float _aiMinDriveLookaheadOffset;
        [FieldAttr(ctr: 104)] public ETrophy _shortcutAchievement;
        [FieldAttr(ctr: 112)] public CEntityHandleList? _shortcutTriggers;
        [FieldAttr(ctr: 120)] public float _onlineDistanceToHidePositionInFinalLap;
        [FieldAttr(ctr: 124)] public EDriverFaction _overrideFaction;
    }
}
