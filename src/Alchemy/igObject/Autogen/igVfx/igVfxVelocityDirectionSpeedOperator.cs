namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 16)]
    public class igVfxVelocityDirectionSpeedOperator : igVfxVelocityBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(nst: 64, ctr: 48)] public float _speed;
    }
}
