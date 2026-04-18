namespace Alchemy
{
    [ObjectAttr(ctr: 152, align: 8)]
    public class CGrandPrixSystemData : igObject
    {
        [FieldAttr(ctr: 12)] public uint _currentGrandPrixVersion;
        [FieldAttr(ctr: 16)] public CChallengeGroupOrderList? _challengeGroupOrderList;
        [FieldAttr(ctr: 24)] public CChallengeGroupInfoList? _challengeGroupInfoList;
        [FieldAttr(ctr: 32)] public CNitroBarTierList? _nitroBarTiers;
        [FieldAttr(ctr: 40)] public float _challengeCompleteListTimeout;
        [FieldAttr(ctr: 44)] public int _tierRewardCount;
        [FieldAttr(ctr: 48)] public string? _countString;
        [FieldAttr(ctr: 56)] public string? _nitrosString;
        [FieldAttr(ctr: 64)] public string? _challengeCompletedNitroGiven;
        [FieldAttr(ctr: 72)] public string? _grandPrixString;
        [FieldAttr(ctr: 80)] public COctaneGrandPrixVignetteStringTable? _vignettesStringTable;
        [FieldAttr(ctr: 88)] public CMarketplaceItemHandleList? _grandPrixLeaderboardBaseRewards;
        [FieldAttr(ctr: 96)] public CMarketplaceItemHandleListList? _grandPrixLeaderboardRewardQueue;
        [FieldAttr(ctr: 104)] public CStatisticData? _currentGrandPrixWinsLeaderboard;
        [FieldAttr(ctr: 112)] public CStatisticData? _currentGrandPrixNitroLeaderboard;
        [FieldAttr(ctr: 120)] public igIntList? _grandPrixPointsPerPosition;
        [FieldAttr(ctr: 128)] public int _leaderboardRewardPercent;
        [FieldAttr(ctr: 136)] public string? _weekendBonusString;
        [FieldAttr(ctr: 144)] public string? _dailyIncentiveBonusString;
    }
}
