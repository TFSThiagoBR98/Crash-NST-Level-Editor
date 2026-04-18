namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class COutfitMaterialData : igObject
    {
        [FieldAttr(ctr: 16)] public COutfitMaterialFileList? _materialFiles;
        [FieldAttr(ctr: 24)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(ctr: 32)] public igHandleMetaField _hudPortrait = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _minimapIcon = new();
    }
}
