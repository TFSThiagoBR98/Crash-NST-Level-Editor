namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 8)]
    public class CMarketplaceBundleSku : CMarketplaceSku
    {
        [FieldAttr(ctr: 136)] public CMarketplaceSkuHandleList? _bundledSkus;
        [FieldAttr(ctr: 144)] public string? _name;
        [FieldAttr(ctr: 152)] public CMarketplaceProductItemList? _cachedItemList;
    }
}
