namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 4)]
    public class CGuiListItemPopulatorGrandPrixReward : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public int _tierId;
        [FieldAttr(ctr: 16)] public bool _refreshRewards;
        [FieldAttr(ctr: 17)] public bool _playUnlockAnim;
        [FieldAttr(ctr: 18)] public bool _waitingOnUnlockAnim;
        [FieldAttr(ctr: 20)] public int _idPlayingUnlockAnim;
        [FieldAttr(ctr: 24)] public int _rewardToUnlock;
    }
}
