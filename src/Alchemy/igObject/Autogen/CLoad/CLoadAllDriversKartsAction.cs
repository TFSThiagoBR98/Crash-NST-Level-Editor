namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CLoadAllDriversKartsAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 36)] public int _numPlayers;
        [FieldAttr(ctr: 40)] public bool _captureMemory;
        [FieldAttr(ctr: 41)] public bool _doScreenGrab;
        [FieldAttr(ctr: 42)] public bool _testCustomizationPermutations;
        [FieldAttr(ctr: 44)] public int _characterIndex;
        [FieldAttr(ctr: 48)] public string? _currentCharacterName;
        [FieldAttr(ctr: 56)] public int _outfitIndex;
        [FieldAttr(ctr: 60)] public EOutfitType _outfitTypeIndex;
        [FieldAttr(ctr: 64)] public CDriverSkinData? _skinData;
        [FieldAttr(ctr: 72)] public bool[] _finishedCustomization = new bool[4];
        [FieldAttr(ctr: 76)] public bool[] _finishedCustomizationScreenGrab = new bool[4];
        [FieldAttr(ctr: 80)] public ECharacterType _characterType;
        [FieldAttr(ctr: 84)] public EPlayerId _playerId;
        [FieldAttr(ctr: 88)] public EVehicleId _vehicleId;
        [FieldAttr(ctr: 92)] public ELoadAllHeroesActionState _state;
        [FieldAttr(ctr: 96)] public CRacerDriverDataList? _driverList;
        [FieldAttr(ctr: 104)] public CRacerKartDataList? _kartsList;
        [FieldAttr(ctr: 112)] public bool _initialized;
        [FieldAttr(ctr: 120)] public igBufferedFile? _memCaptureFile;
        [FieldAttr(ctr: 128)] public CHeroScreenGrabAction? _heroScreenGrabAction;
        [FieldAttr(ctr: 136)] public bool _skipScreenGrab;
        [FieldAttr(ctr: 144)] public CActorTimeScale? _driverTimeScale;
        [FieldAttr(ctr: 152)] public CActorTimeScale? _kartTimeScale;
        [FieldAttr(ctr: 160)] public igSizeTypeMetaField _currentPeakKartSize = new();
        [FieldAttr(ctr: 168)] public EKartCustomizationType _currentSwappedCustom;
        [FieldAttr(ctr: 172)] public bool _skipTest;
    }
}
