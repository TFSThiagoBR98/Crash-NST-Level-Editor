namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igGraphicsTexture : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public EigResourceUsage _usage;
        [FieldAttr(nst: 32, ctr: 32)] public igImage2? _image;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _imageHandle = new();
        [FieldAttr(nst: 48, ctr: 48)] public igSizeTypeMetaField _resource = new();
    }
}
