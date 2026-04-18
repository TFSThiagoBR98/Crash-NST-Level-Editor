namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CMarketplaceTimeWeight : igObject
    {
        [FieldAttr(ctr: 12)] public uint _daysSinceSaleStarted;
        [FieldAttr(ctr: 16)] public float _weight;
    }
}
