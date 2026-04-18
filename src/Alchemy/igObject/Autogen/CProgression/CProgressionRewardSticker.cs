namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CProgressionRewardSticker : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _sticker = new();
    }
}
