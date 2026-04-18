namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class COnlinePlaylistData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _displayName;
        [FieldAttr(ctr: 24)] public EOctaneRaceModes _raceMode;
        [FieldAttr(ctr: 28)] public int _minPlayerCount;
        [FieldAttr(ctr: 32)] public int _maxPlayerCount;
        [FieldAttr(ctr: 36)] public EDifficultyLevel _aiMatchmakingDifficulty;
        [FieldAttr(ctr: 40)] public igStringRefList? _mapList;
        [FieldAttr(ctr: 48)] public COnlinePlaylistMapDataList? _weightedMapList;
        [FieldAttr(ctr: 56)] public bool _usePerformance;
    }
}
