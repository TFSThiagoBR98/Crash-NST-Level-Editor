namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class igAlphaFunctionAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public EIG_GFX_ALPHA_FUNCTION _func = EIG_GFX_ALPHA_FUNCTION.GEQUAL;
        [FieldAttr(nst: 28, ctr: 24)] public float _refValue;
    }
}
