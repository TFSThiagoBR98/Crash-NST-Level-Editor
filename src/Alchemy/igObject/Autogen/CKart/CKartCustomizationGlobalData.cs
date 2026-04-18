namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 8)]
    public class CKartCustomizationGlobalData : igObject
    {
        [FieldAttr(ctr: 16)] public CKartCustomizationColorSchemeList? _colorSchemes;
        [FieldAttr(ctr: 24)] public CStringKartCustomizationDecalListTable? _decals;
        [FieldAttr(ctr: 32)] public CKartCustomizationStickerList? _stickers;
        [FieldAttr(ctr: 40)] public CKartCustomizationItemList? _kartWheelsCustomizationData;
        [FieldAttr(ctr: 48)] public CKartCustomizationPresetItemList? _customizationPresets;
        [FieldAttr(ctr: 56)] public igHandleMetaField _noPresetIcon = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _kartBodySelectedSFX = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _paintSelectedSFX = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _decalSelectedSFX = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _stickerSelectedSFX = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _wheelSelectedSFX = new();
        [FieldAttr(ctr: 104)] public CKartCustomizationGroupList? _stickerGroups;
        [FieldAttr(ctr: 112)] public CKartCustomizationGroupList? _colorSchemeMaterialGroups;
        [FieldAttr(ctr: 120)] public CKartCustomizationGroupList? _colorSchemeColorGroups;
    }
}
