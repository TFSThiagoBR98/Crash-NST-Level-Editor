namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 112, align: 8)]
    public class igVfxAlphaCurveOperator : igVfxAlphaBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _alpha = new();
        [FieldAttr(nst: 116, ctr: 104)] public EOperatorCurveInput _alphaInput;
    }
}
