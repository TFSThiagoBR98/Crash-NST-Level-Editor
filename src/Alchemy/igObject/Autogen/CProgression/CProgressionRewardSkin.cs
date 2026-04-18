namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionRewardSkin : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _skin = new();
        [FieldAttr(ctr: 24)] public string? _driverName;
    }
}
