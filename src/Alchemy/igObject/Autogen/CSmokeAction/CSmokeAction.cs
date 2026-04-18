namespace Alchemy
{
    [ObjectAttr(ctr: 184, align: 8)]
    public class CSmokeAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 36)] public uint [] _timers = new u32 /* igStructMetaField */[3];
        [FieldAttr(ctr: 60)] public EActionType _type;
        [FieldAttr(ctr: 64)] public uint _mapOptions;
        [FieldAttr(ctr: 72)] public igStringRefList? _namedHeroLoadList;
        [FieldAttr(ctr: 80)] public igStringRefList? _namedHeroOutfitLoadList;
        [FieldAttr(ctr: 88)] public igStringRefList? _namedVehicleLoadList;
        [FieldAttr(ctr: 96)] public igStringRefList? _namedKartWheelsLoadList;
        [FieldAttr(ctr: 104)] public bool _aisUseSameHero;
        [FieldAttr(ctr: 105)] public bool _aisUseSameKart;
        [FieldAttr(ctr: 106)] public bool _aisUseSameKartWheels;
        [FieldAttr(ctr: 107)] public bool _enableTrainingWheels;
        [FieldAttr(ctr: 108)] public EGameMode _gameMode;
        [FieldAttr(ctr: 112)] public CCheckpoint? _checkpoint;
        [FieldAttr(ctr: 120)] public float _time;
        [FieldAttr(ctr: 124)] public float _waitTime;
        [FieldAttr(ctr: 128)] public bool _lockFramerate;
        [FieldAttr(ctr: 129)] public bool _addPerformanceStatsBetweenLoads;
        [FieldAttr(ctr: 130)] public bool _skipMapSave;
        [FieldAttr(ctr: 131)] public bool _allMaps;
        [FieldAttr(ctr: 132)] public bool _dynamicMaps;
        [FieldAttr(ctr: 136)] public igStringRefList? _allMapsExclusionList;
        [FieldAttr(ctr: 144)] public string? _captureZoneName;
        [FieldAttr(ctr: 152)] public bool _captureMemory;
        [FieldAttr(ctr: 156)] public int _lapCount;
        [FieldAttr(ctr: 160)] public int _raceAICount;
        [FieldAttr(ctr: 164)] public bool _forceDockedConfiguration;
        [FieldAttr(ctr: 165)] public bool _additionalPerfCounter;
        [FieldAttr(ctr: 166)] public bool _initialized;
        [FieldAttr(ctr: 167)] public bool _startedMapLoad;
        [FieldAttr(ctr: 168)] public bool _waitForUnitTests;
        [FieldAttr(ctr: 172)] public int _currentHeroIndex;
        [FieldAttr(ctr: 176)] public float _performanceStatsTimer;
        [FieldAttr(ctr: 180)] public bool _waitForRaceFinish;
    }
}
