namespace Alchemy
{
    [ObjectAttr(nst: 296, ctr: 280, align: 8)]
    public class igVfxAccelerateCurveOperator : igVfxAccelerateBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _x = new();
        [FieldAttr(nst: 116, ctr: 104)] public igVfxRangedCurveMetaField _y = new();
        [FieldAttr(nst: 200, ctr: 188)] public igVfxRangedCurveMetaField _z = new();
        [FieldAttr(nst: 284, ctr: 272)] public EigVfxCurveCorrelation _correlation;
        [FieldAttr(nst: 288, ctr: 276)] public EOperatorCurveInput _accelerationInput;
    }
}
