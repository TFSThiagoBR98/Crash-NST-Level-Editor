namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CAlphaClipBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _enable;
        [FieldAttr(nst: 28, ctr: 28)] public float _threshold = 0.5f;
    }
}
