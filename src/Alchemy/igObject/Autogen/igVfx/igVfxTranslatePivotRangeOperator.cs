namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class igVfxTranslatePivotRangeOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public igRangedFloatMetaField _x = new();
        [FieldAttr(nst: 32, ctr: 24)] public igRangedFloatMetaField _y = new();
        [FieldAttr(nst: 40, ctr: 32)] public igRangedFloatMetaField _z = new();
        [FieldAttr(nst: 48, ctr: 40)] public EigVfxCurveCorrelation _correlation;
    }
}
