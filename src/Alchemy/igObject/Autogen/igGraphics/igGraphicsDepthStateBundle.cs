namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGraphicsDepthStateBundle : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igDepthStateBundleDescMetaField _depthStateBundle = new();
        [FieldAttr(nst: 40, ctr: 40)] public igSizeTypeMetaField _resource = new();
    }
}
