namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 280, align: 8)]
    public class igVfxTranslatePivotCurveOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVfxRangedCurveMetaField _x = new();
        [FieldAttr(nst: 108, ctr: 100)] public igVfxRangedCurveMetaField _y = new();
        [FieldAttr(nst: 192, ctr: 184)] public igVfxRangedCurveMetaField _z = new();
        [FieldAttr(nst: 276, ctr: 268)] public EOperatorCurveInput _pivotInput;
        [FieldAttr(nst: 280, ctr: 272)] public EigVfxCurveCorrelation _correlation;
    }
}
