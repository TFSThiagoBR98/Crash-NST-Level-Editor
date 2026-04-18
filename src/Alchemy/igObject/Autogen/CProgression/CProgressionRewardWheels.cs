namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CProgressionRewardWheels : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _wheels = new();
    }
}
