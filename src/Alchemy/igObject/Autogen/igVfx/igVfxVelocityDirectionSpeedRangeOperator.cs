namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 16)]
    public class igVfxVelocityDirectionSpeedRangeOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(nst: 64, ctr: 48)] public igRangedFloatMetaField _speed = new();
    }
}
