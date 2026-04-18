namespace Alchemy
{
    [ObjectAttr(nst: 304, ctr: 288, align: 8)]
    public class igVfxVelocityCurveOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 40, ctr: 24)] public igVfxRangedCurveMetaField _x = new();
        [FieldAttr(nst: 124, ctr: 108)] public igVfxRangedCurveMetaField _y = new();
        [FieldAttr(nst: 208, ctr: 192)] public igVfxRangedCurveMetaField _z = new();
        [FieldAttr(nst: 292, ctr: 276)] public EOperatorCurveInput _velocityInput;
        [FieldAttr(nst: 296, ctr: 280)] public EigVfxCurveCorrelation _correlation;
    }
}
