namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 104, align: 8)]
    public class CVehiclePersonalizationBaseItem : CMarketplaceItem
    {
        [FieldAttr(nst: 40, ctr: 80)] public string? _dataPackage = null;
        [FieldAttr(nst: 48, ctr: 88)] public igHandleMetaField _iconGuiMaterial = new();
        [FieldAttr(nst: 56, ctr: 96)] public int _itemIndex = -1;
    }
}
