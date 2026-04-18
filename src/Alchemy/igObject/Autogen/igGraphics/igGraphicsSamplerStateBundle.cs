namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igGraphicsSamplerStateBundle : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igSamplerStateBundleDescMetaField _samplerStateBundle = new();
        [FieldAttr(nst: 64, ctr: 64)] public igSizeTypeMetaField _resource = new();
    }
}
