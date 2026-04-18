namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CMarketplaceCurrency : igObject
    {
        [FieldAttr(ctr: 12)] public uint _id;
        [FieldAttr(ctr: 16)] public string? _currencyCode;
    }
}
