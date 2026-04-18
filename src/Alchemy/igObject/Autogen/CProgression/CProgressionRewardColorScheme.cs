namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CProgressionRewardColorScheme : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _colorScheme = new();
    }
}
