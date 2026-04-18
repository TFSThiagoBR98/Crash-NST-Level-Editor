namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 8)]
    public class CDriverSkinData : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _adventureUnlockIcon = new();
        [FieldAttr(ctr: 96)] public COutfitData? _outfit;
        [FieldAttr(ctr: 104)] public igHandleMetaField _outfitHandle = new();
        [FieldAttr(ctr: 112)] public string? _selectedVoName;
    }
}
