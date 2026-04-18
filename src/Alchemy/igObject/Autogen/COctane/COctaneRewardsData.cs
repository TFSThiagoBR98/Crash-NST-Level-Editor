namespace Alchemy
{
    [ObjectAttr(ctr: 232, align: 8)]
    public class COctaneRewardsData : igSingleton
    {
        [FieldAttr(ctr: 16)] public CProgressionChallengeList? _challengeList;
        [FieldAttr(ctr: 24)] public string? _kartDefaultName;
        [FieldAttr(ctr: 32)] public string? _driverDefaultName;
        [FieldAttr(ctr: 40)] public string? _skinDefaultName;
        [FieldAttr(ctr: 48)] public string? _stickerDefaultName;
        [FieldAttr(ctr: 56)] public string? _decalDefaultName;
        [FieldAttr(ctr: 64)] public string? _noDecalDefaultName;
        [FieldAttr(ctr: 72)] public string? _paintjobDefaultName;
        [FieldAttr(ctr: 80)] public string? _wheelsDefaultName;
        [FieldAttr(ctr: 88)] public string? _presetDefaultName;
        [FieldAttr(ctr: 96)] public string? _noPresetDefaultName;
        [FieldAttr(ctr: 104)] public string? _wumpaCoinsString;
        [FieldAttr(ctr: 112)] public string? _driverWinsUnlockString;
        [FieldAttr(ctr: 120)] public string? _driverOneWinsUnlockString;
        [FieldAttr(ctr: 128)] public string? _beatNefariousTimesUnlockString;
        [FieldAttr(ctr: 136)] public string? _beatOxideTimesUnlockString;
        [FieldAttr(ctr: 144)] public string? _pitStopUnlockString;
        [FieldAttr(ctr: 152)] public string? _grandPrixUnlockString;
        [FieldAttr(ctr: 160)] public string? _leaderboardUnlockString;
        [FieldAttr(ctr: 168)] public string? _grandPrixRetiredString;
        [FieldAttr(ctr: 176)] public igHandleMetaField _wumpaCoinMaterial = new();
        [FieldAttr(ctr: 184)] public CRacerDriverDataHandleList? _characterUnlockDriverList;
        [FieldAttr(ctr: 192)] public igHandleMetaField _baseLockIcon = new();
        [FieldAttr(ctr: 200)] public igHandleMetaField _pitStopLockIcon = new();
        [FieldAttr(ctr: 208)] public igHandleMetaField _grandPrixLockIcon = new();
        [FieldAttr(ctr: 216)] public igHandleMetaField _leaderboardLockIcon = new();
        [FieldAttr(ctr: 224)] public igHandleMetaField _retiredLockIcon = new();
    }
}
