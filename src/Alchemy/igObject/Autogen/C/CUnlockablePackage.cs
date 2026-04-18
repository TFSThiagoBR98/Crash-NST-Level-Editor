namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CUnlockablePackage : igObject
    {
        [FieldAttr(ctr: 16)] public string? _unlockableName;
        [FieldAttr(ctr: 24)] public CMarketplaceItemHandleList? _marketplaceItems;
        [FieldAttr(ctr: 32)] public CMarketplaceProductCurrencyList? _marketplaceCurrencies;
    }
}
