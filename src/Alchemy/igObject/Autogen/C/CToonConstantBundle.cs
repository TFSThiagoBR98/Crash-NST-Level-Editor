namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CToonConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float fade = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float lineWidth = 1.0f;
    }
}
