namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CBloomConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _bloomLuminanceScale = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _bloomLuminanceBias = 1.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _bloomScale = 1.0f;
    }
}
