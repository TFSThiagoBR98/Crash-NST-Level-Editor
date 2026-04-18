namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class igVfxRotateEulerRangedRampOperator : igVfxFrameOperator
    {
        [FieldAttr(ctr: 20)] public igVfxRangedRampMetaField _x = new();
        [FieldAttr(ctr: 36)] public igVfxRangedRampMetaField _y = new();
        [FieldAttr(ctr: 52)] public igVfxRangedRampMetaField _z = new();
        [FieldAttr(ctr: 68)] public EigVfxCurveCorrelation _correlation;
    }
}
