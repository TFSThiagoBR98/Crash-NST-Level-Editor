namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 8)]
    public class CKartCustomizationDecal : CKartCustomizationPart
    {
        [FieldAttr(ctr: 104)] public igHandleMetaField _material = new();
        [FieldAttr(ctr: 112)] public string? _kartName;
    }
}
