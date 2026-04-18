namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CMarketplaceProductCurrency : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _currency = new();
        [FieldAttr(ctr: 24)] public uint _quantity;
    }
}
