namespace Alchemy
{
    [ObjectAttr(ctr: 16, align: 4)]
    public class CProgressionRewardWumpaCoins : CProgressionReward
    {
        [FieldAttr(ctr: 12)] public int _coinAmount;
    }
}
