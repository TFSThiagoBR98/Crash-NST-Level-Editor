namespace Alchemy
{
    [ObjectAttr(nst: 392, ctr: 376, align: 8)]
    public class igVfxOrbitEulerCurveRadiusCurveOperator : igVfxOrbitBaseOperator
    {
        [FieldAttr(nst: 40, ctr: 24)] public igVfxRangedCurveMetaField _x = new();
        [FieldAttr(nst: 124, ctr: 108)] public igVfxRangedCurveMetaField _y = new();
        [FieldAttr(nst: 208, ctr: 192)] public igVfxRangedCurveMetaField _z = new();
        [FieldAttr(nst: 292, ctr: 276)] public EOperatorCurveInput _eulerInput;
        [FieldAttr(nst: 296, ctr: 280)] public EigVfxCurveCorrelation _correlation;
        [FieldAttr(nst: 300, ctr: 284)] public igVfxRangedCurveMetaField _radius = new();
        [FieldAttr(nst: 384, ctr: 368)] public EOperatorCurveInput _radiusInput;
    }
}
