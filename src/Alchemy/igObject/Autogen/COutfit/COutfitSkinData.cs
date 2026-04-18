namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class COutfitSkinData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _defaultSkin;
        [FieldAttr(ctr: 24)] public CStrippedRacerLODList? _lodSkins;
        [FieldAttr(ctr: 32)] public string? _defaultSkinConverted;
        [FieldAttr(ctr: 40)] public igHandleMetaField _hudPortrait = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _minimapIcon = new();
    }
}
