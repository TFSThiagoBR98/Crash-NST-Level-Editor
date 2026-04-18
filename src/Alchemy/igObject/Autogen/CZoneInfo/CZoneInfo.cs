namespace Alchemy
{
    [ObjectAttr(nst: 400, ctr: 448, align: 8)]
    public class CZoneInfo : CChunkInfo
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isBoss;
            [FieldAttr(offset: 1, size: 1)] public bool _magicMomentIntro;
            [FieldAttr(offset: 2, size: 1)] public bool _isMenu;
            [FieldAttr(offset: 3, size: 1)] public bool _isFmv;
            [FieldAttr(offset: 4, size: 1)] public bool _isSecret;
            [FieldAttr(offset: 5, size: 1)] public bool _smokeTestAllMaps;
            [FieldAttr(offset: 6, size: 1)] public bool _smokeTestAllMapsCafe;
            [FieldAttr(offset: 7, size: 1)] public bool _alwaysUseHugoVoiceOvers;
        }

        [FieldAttr(nst: 32, ctr: 32)] public string? _debugMenuName = null;
        [FieldAttr(nst: 40, ctr: 40)] public ELevelStreamingType _levelStreamingType;
        [FieldAttr(nst: 44, ctr: 44)] public int _manualChunkCount = 2;
        [FieldAttr(nst: 48, ctr: 48)] public igSizeTypeMetaField _levelPoolSize = new();
        [FieldAttr(nst: 56, ctr: 56)] public igSizeTypeMetaField _globalChunkPoolSize = new();
        [FieldAttr(nst: 64, ctr: 64)] public float _platinumTime = 120.0f;
        [FieldAttr(nst: 68, ctr: 68)] public float _goldTime = 180.0f;
        [FieldAttr(nst: 72, ctr: 72)] public float _sapphireTime = 240.0f;
        [FieldAttr(ctr: 80)] public CDifficultySpecificFloat? _platinumTimes;
        [FieldAttr(ctr: 88)] public CDifficultySpecificFloat? _goldTimes;
        [FieldAttr(ctr: 96)] public CDifficultySpecificFloat? _sapphireTimes;
        [FieldAttr(nst: 80, ctr: 104)] public string? _loadMovieName = null;
        [FieldAttr(nst: 88, ctr: 112)] public string? _loadScreenName = null;
        [FieldAttr(ctr: 120)] public string? _previewMovie;
        [FieldAttr(nst: 96, ctr: 128)] public string? _menuToOpenOnLoad = null;
        [FieldAttr(nst: 104, ctr: 136)] public string? _saveName = null;
        [FieldAttr(nst: 112, ctr: 144)] public string? _build = "normal";
        [FieldAttr(nst: 120, ctr: 152)] public EGameYear _year = EGameYear.eGY_Count;
        [FieldAttr(nst: 124, ctr: 156)] public EZoneCategory _category = EZoneCategory.eZC_Count;
        [FieldAttr(nst: 128, ctr: 160)] public string? _displayName = null;
        [FieldAttr(nst: 136, ctr: 168)] public string? _hint = "";
        [FieldAttr(nst: 144, ctr: 176)] public string? _bossName = null;
        [FieldAttr(nst: 152, ctr: 184)] public string? _storyModePresenceText = null;
        [FieldAttr(nst: 160, ctr: 192)] public Flags _flags = new();
        [FieldAttr(nst: 164, ctr: 196)] public float _cameraNearPlane = 32.0f;
        [FieldAttr(nst: 168, ctr: 200)] public float _cameraClipPlane = 2.0f;
        [FieldAttr(nst: 172, ctr: 204)] public float _smokeTestTimeLimit = 2.0f;
        [FieldAttr(nst: 176, ctr: 208)] public float _screenOuterSafeAreaRight = 50.0f;
        [FieldAttr(nst: 180, ctr: 212)] public float _screenOuterSafeAreaLeft = 50.0f;
        [FieldAttr(nst: 184, ctr: 216)] public float _screenOuterSafeAreaTop = 50.0f;
        [FieldAttr(nst: 188, ctr: 220)] public float _screenOuterSafeAreaBottom = 50.0f;
        [FieldAttr(nst: 192, ctr: 224)] public float _screenOuterSafeAreaBottomCoop = 90.0f;
        [FieldAttr(nst: 196, ctr: 228)] public int _targetLevel = 1;
        [FieldAttr(nst: 200, ctr: 232)] public float _defaultCameraTargetRadiusOverride = -1.0f;
        [FieldAttr(nst: 204, ctr: 236)] public EZoneInfoProgressionGroup _progressionGroup;
        [FieldAttr(nst: 208, ctr: 240)] public igHandleMetaField _nextMap = new();
        [FieldAttr(nst: 216, ctr: 248)] public igHandleMetaField _juiceDomain = new();
        [FieldAttr(nst: 224)] public CStatisticData? _highScoreLeaderboard;
        [FieldAttr(nst: 232)] public CStatisticData? _fastestRaceTimeLeaderboard;
        [FieldAttr(nst: 240)] public CStatisticData? _fastestOnlineRaceTimeLeaderboard;
        [FieldAttr(nst: 248)] public CStatisticData? _fastestLapTimeLeaderboard;
        [FieldAttr(nst: 256, ctr: 256)] public CStatisticData? _fastestTimeTrialLeaderboard;
        [FieldAttr(ctr: 264)] public CStatisticData? _fastestRelicRaceLeaderboard;
        [FieldAttr(nst: 264, ctr: 272)] public CLevelGoalList? _levelObjectives;
        [FieldAttr(nst: 272, ctr: 280)] public igHandleMetaField _landObjective = new();
        [FieldAttr(nst: 280, ctr: 288)] public igHandleMetaField _seaObjective = new();
        [FieldAttr(nst: 288, ctr: 296)] public igHandleMetaField _skyObjective = new();
        [FieldAttr(nst: 296, ctr: 304)] public bool _endsOnAStar;
        [FieldAttr(nst: 304, ctr: 312)] public CCheckpointList? _checkpoints;
        [FieldAttr(nst: 312, ctr: 320)] public igHandleMetaField _associatedStoryQuest = new();
        [FieldAttr(nst: 320, ctr: 328)] public EGameStateKey _levelStartedCountGameState = EGameStateKey.eGSK_None;
        [FieldAttr(nst: 324, ctr: 332)] public EGameStateKey _levelCompletedCountGameState = EGameStateKey.eGSK_None;
        [FieldAttr(nst: 328, ctr: 336)] public EGameStateKey _collectiblesRewardedBitMask = EGameStateKey.eGSK_None;
        [FieldAttr(nst: 332, ctr: 340)] public float _expectedCompletionTime = 300.0f;
        [FieldAttr(nst: 336, ctr: 344)] public CZoneInfoSave? _saveData;
        [FieldAttr(nst: 344, ctr: 352)] public int _progressionIndex = -1;
        [FieldAttr(nst: 348, ctr: 356)] public int _dynamicDifficultyIndex = -1;
        [FieldAttr(nst: 352, ctr: 360)] public int _dynamicDifficultyTargetTime;
        [FieldAttr(nst: 356, ctr: 364)] public float _aoBakeMinRayDistance = 0.1f;
        [FieldAttr(nst: 360, ctr: 368)] public float _aoBakeMaxRayDistance = 1.0f;
        [FieldAttr(nst: 364, ctr: 372)] public float _aoBakeRegularization = 0.1f;
        [FieldAttr(nst: 368, ctr: 376)] public igHandleMetaField _saveSlotImage = new();
        [FieldAttr(nst: 376, ctr: 384)] public bool _planarReflectionsEnabled;
        [FieldAttr(ctr: 392)] public CLensFlareData? _lensFlareData;
        [FieldAttr(nst: 384, ctr: 400)] public string? _overrideCharacter = null;
        [FieldAttr(nst: 392, ctr: 408)] public string? _zoneVehicle = null;
        [FieldAttr(ctr: 416)] public int _maximumNumberOfRacers;
        [FieldAttr(ctr: 424)] public COctaneZoneData? _octaneZoneData;
        [FieldAttr(ctr: 432)] public COctaneLevelSelectData? _levelSelectData;
        [FieldAttr(ctr: 440)] public COctaneCupSelectDataListList? _cupSelectData;
    }
}
