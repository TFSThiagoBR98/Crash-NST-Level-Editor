namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 56, align: 8)]
    public class igVfxVelocityRangeOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 40, ctr: 24)] public igRangedFloatMetaField _x = new();
        [FieldAttr(nst: 48, ctr: 32)] public igRangedFloatMetaField _y = new();
        [FieldAttr(nst: 56, ctr: 40)] public igRangedFloatMetaField _z = new();
        [FieldAttr(nst: 64, ctr: 48)] public EigVfxCurveCorrelation _correlation;
    }
}
