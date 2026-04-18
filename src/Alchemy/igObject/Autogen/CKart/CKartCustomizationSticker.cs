namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 8)]
    public class CKartCustomizationSticker : CKartCustomizationPart
    {
        [FieldAttr(ctr: 104)] public igHandleMetaField _material = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _mirrorModeMaterial = new();
        [FieldAttr(ctr: 120)] public CKartCustomizationGroup? _stickerGroup;
    }
}
