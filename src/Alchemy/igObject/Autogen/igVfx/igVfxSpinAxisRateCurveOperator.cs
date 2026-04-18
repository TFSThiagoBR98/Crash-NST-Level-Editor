namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 16)]
    public class igVfxSpinAxisRateCurveOperator : igVfxSpinAxisRateBaseOperator
    {
        [FieldAttr(nst: 64)] public igVfxRangedCurveMetaField _rate = new();
        [FieldAttr(nst: 148)] public EOperatorCurveInput _rateInput;
    }
}
