namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 144, align: 16)]
    public class igVfxVelocityDirectionSpeedCurveOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(nst: 64, ctr: 48)] public igVfxRangedCurveMetaField _speed = new();
        [FieldAttr(nst: 148, ctr: 132)] public EOperatorCurveInput _speedInput;
    }
}
