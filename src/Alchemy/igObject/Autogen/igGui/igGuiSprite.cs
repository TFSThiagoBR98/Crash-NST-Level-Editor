namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 16)]
    public class igGuiSprite : igGuiAsset
    {
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igSprite? _renderSprite;
        [FieldAttr(nst: 48, ctr: 48)] public bool _imageSizeFromSource;
        [FieldAttr(nst: 52, ctr: 52)] public float _imageWidth;
        [FieldAttr(nst: 56, ctr: 56)] public float _imageHeight;
    }
}
