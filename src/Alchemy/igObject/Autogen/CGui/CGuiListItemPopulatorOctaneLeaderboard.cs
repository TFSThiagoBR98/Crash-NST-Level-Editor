namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CGuiListItemPopulatorOctaneLeaderboard : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public string? _currentZoneName;
        [FieldAttr(ctr: 24)] public string? _wantedZoneName;
        [FieldAttr(ctr: 32)] public EOctaneRaceModes _currentRaceMode;
        [FieldAttr(ctr: 36)] public EOctaneRaceModes _wantedRaceMode;
        [FieldAttr(ctr: 40)] public EOctaneLeaderboardPopulationType _currentPopulation;
        [FieldAttr(ctr: 44)] public EOctaneLeaderboardPopulationType _wantedPopulation;
        [FieldAttr(ctr: 48)] public EOctaneLeaderboardType _currentType;
        [FieldAttr(ctr: 52)] public EOctaneLeaderboardType _wantedType;
        [FieldAttr(ctr: 56)] public int _wantedStartIndex;
        [FieldAttr(ctr: 60)] public int _currentStartIndex;
        [FieldAttr(ctr: 64)] public ELeaderboardRankFocus _currentRankFocus;
        [FieldAttr(ctr: 68)] public ELeaderboardRankFocus _wantedRankFocus;
        [FieldAttr(ctr: 72)] public igTimeMetaField _delayReadQueryEndTime = new();
        [FieldAttr(ctr: 76)] public EeLeaderboardPopulatorState _currentState;
        [FieldAttr(ctr: 80)] public COctaneLeaderboardReadResultBase? _pendingLeaderboardReadResults;
        [FieldAttr(ctr: 88)] public bool _playerResultsDirty;
        [FieldAttr(ctr: 89)] public bool _hasPlayerResultsToShow;
        [FieldAttr(ctr: 90)] public bool _hasReachedLeaderboardfEnd;
        [FieldAttr(ctr: 91)] public bool _scrollingUp;
        [FieldAttr(ctr: 92)] public bool _loaded;
    }
}
