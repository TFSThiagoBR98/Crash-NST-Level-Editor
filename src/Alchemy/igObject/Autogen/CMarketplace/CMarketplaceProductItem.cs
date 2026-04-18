namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CMarketplaceProductItem : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _item = new();
        [FieldAttr(ctr: 24)] public uint _quantity;
    }
}
