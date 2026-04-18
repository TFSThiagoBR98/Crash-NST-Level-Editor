namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igGraphicsRasterizerStateBundle : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igRasterizerStateBundleDescMetaField _rasterizerStateBundle = new();
        [FieldAttr(nst: 56, ctr: 56)] public igSizeTypeMetaField _resource = new();
    }
}
