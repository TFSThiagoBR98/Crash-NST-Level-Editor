namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CGrandPrixCustomizationsNPMultiplier : igObject
    {
        [FieldAttr(ctr: 12)] public int _multiplier;
        [FieldAttr(ctr: 16)] public CMarketplaceItemHandleList? _itemList;
    }
}
