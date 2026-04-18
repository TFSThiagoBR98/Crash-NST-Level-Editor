namespace Alchemy
{
    [ObjectAttr(ctr: 168, align: 8)]
    public class CMarketplaceData : igObject
    {
        [FieldAttr(ctr: 12)] public uint _baseItemId;
        [FieldAttr(ctr: 16)] public uint _baseProductId;
        [FieldAttr(ctr: 20)] public uint _baseCurrencyId;
        [FieldAttr(ctr: 24)] public uint _baseSkuId;
        [FieldAttr(ctr: 32)] public string? _storeMenuName;
        [FieldAttr(ctr: 40)] public igHandleMetaField _checkmarkIcon = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _warningIcon = new();
        [FieldAttr(ctr: 56)] public EOctaneMarketplaceItemCategoryList? _bundlesOrder;
        [FieldAttr(ctr: 64)] public EOctaneMarketplaceItemCategoryListList? _categoryPriorities;
        [FieldAttr(ctr: 72)] public CMarketplaceItemShowcaseWeights? _itemShowcaseWeights;
        [FieldAttr(ctr: 80)] public CMarketplaceFeaturedSkuCalendar? _featuredItemsCalendar;
        [FieldAttr(ctr: 88)] public CMarketplaceItemHandleList? _marketplaceItems;
        [FieldAttr(ctr: 96)] public CMarketplaceCurrencyList? _marketplaceCurrencies;
        [FieldAttr(ctr: 104)] public CMarketplaceProductList? _marketplaceProducts;
        [FieldAttr(ctr: 112)] public CMarketplaceSkuList? _marketplaceSkus;
        [FieldAttr(ctr: 120)] public CMarketplaceExchangeSkuDataList? _marketplaceExchangeSkus;
        [FieldAttr(ctr: 128)] public CUnlockablePackageList? _packages;
        [FieldAttr(ctr: 136)] public CUnlockablePackageFirstPartyList? _firstPartyPackages;
        [FieldAttr(ctr: 144)] public float _defaultDriverShowcaseScale;
        [FieldAttr(ctr: 152)] public igStringFloatHashTable? _driverShowcaseScaleTable;
        [FieldAttr(ctr: 160)] public EOctaneMarketplaceItemCategoryNamesTable? _categoryNamesTable;
    }
}
