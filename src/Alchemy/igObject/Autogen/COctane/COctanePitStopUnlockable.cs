namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctanePitStopUnlockable : COctaneUnlockable
    {
        [FieldAttr(ctr: 26)] public bool _isGrandPrixReward;
        [FieldAttr(ctr: 27)] public bool _isLeaderboardReward;
        [FieldAttr(ctr: 28)] public bool _isRetired;
    }
}
