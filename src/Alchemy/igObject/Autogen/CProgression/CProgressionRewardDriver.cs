namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CProgressionRewardDriver : CProgressionReward
    {
        [FieldAttr(ctr: 16)] public string? _driverName;
    }
}
