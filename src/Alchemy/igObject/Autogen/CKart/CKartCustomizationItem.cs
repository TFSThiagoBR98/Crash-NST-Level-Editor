namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CKartCustomizationItem : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public string? _name;
        [FieldAttr(ctr: 88)] public string? _package;
        [FieldAttr(ctr: 96)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _adventureUnlockIcon = new();
    }
}
