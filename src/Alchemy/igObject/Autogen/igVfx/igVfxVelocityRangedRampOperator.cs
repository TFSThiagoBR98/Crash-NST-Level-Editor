namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 80, align: 8)]
    public class igVfxVelocityRangedRampOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 40, ctr: 24)] public igVfxRangedRampMetaField _x = new();
        [FieldAttr(nst: 56, ctr: 40)] public igVfxRangedRampMetaField _y = new();
        [FieldAttr(nst: 72, ctr: 56)] public igVfxRangedRampMetaField _z = new();
        [FieldAttr(nst: 88, ctr: 72)] public EigVfxCurveCorrelation _correlation;
    }
}
