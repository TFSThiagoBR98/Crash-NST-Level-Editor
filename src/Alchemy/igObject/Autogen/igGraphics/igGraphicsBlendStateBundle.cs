namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igGraphicsBlendStateBundle : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igBlendStateBundleDescMetaField _blendStateBundle = new();
        [FieldAttr(nst: 64, ctr: 64)] public igSizeTypeMetaField _resource = new();
    }
}
