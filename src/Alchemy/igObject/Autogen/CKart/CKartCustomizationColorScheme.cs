namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CKartCustomizationColorScheme : CKartCustomizationPart
    {
        [FieldAttr(ctr: 104)] public igFxMaterialHandleList? _materials;
        [FieldAttr(ctr: 112)] public igHandleMetaField _decalMaterial = new();
        [FieldAttr(ctr: 120)] public CKartCustomizationGroup? _materialGroup;
        [FieldAttr(ctr: 128)] public CKartCustomizationGroup? _colorGroup;
    }
}
