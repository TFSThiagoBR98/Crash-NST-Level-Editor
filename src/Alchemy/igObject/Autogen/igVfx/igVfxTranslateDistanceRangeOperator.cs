namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 16)]
    public class igVfxTranslateDistanceRangeOperator : igVfxFrameOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(nst: 48, ctr: 48)] public igRangedFloatMetaField _distance = new();
    }
}
