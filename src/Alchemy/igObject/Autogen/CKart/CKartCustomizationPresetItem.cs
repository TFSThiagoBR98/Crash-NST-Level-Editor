namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CKartCustomizationPresetItem : CMarketplaceItem
    {
        [FieldAttr(ctr: 80)] public CKartCustomizationPreset? _kartPreset;
        [FieldAttr(ctr: 88)] public string? _displayName;
        [FieldAttr(ctr: 96)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 104)] public uint _availableCustomizationFlags;
    }
}
