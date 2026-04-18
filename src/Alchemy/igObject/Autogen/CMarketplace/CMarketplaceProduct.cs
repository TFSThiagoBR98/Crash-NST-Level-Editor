namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CMarketplaceProduct : igObject
    {
        [FieldAttr(ctr: 12)] public uint _bitfield;
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public string? _description;
        [FieldAttr(ctr: 32)] public CMarketplaceProductItemList? _items;
        [FieldAttr(ctr: 40)] public CMarketplaceProductCurrencyList? _currencies;
    }
}
