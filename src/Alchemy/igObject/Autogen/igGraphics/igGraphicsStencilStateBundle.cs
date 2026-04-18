namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class igGraphicsStencilStateBundle : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igStencilStateBundleDescMetaField _stencilStateBundle = new();
        [FieldAttr(nst: 80, ctr: 80)] public igSizeTypeMetaField _resource = new();
    }
}
