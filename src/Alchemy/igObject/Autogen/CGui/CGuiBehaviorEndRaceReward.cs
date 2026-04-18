namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorEndRaceReward : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _rewardIconPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _rewardTextPlaceable;
    }
}
