namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igVfxTranslatePivotRangedRampOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVfxRangedRampMetaField _x = new();
        [FieldAttr(nst: 40, ctr: 32)] public igVfxRangedRampMetaField _y = new();
        [FieldAttr(nst: 56, ctr: 48)] public igVfxRangedRampMetaField _z = new();
        [FieldAttr(nst: 72, ctr: 64)] public EigVfxCurveCorrelation _correlation;
    }
}
