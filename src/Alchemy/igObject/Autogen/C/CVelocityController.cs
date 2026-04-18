namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CVelocityController : CBaseMovementController
    {
        [FieldAttr(nst: 56)] public float _speed;
        [FieldAttr(nst: 60)] public igVec3fMetaField _direction = new();
        [FieldAttr(nst: 72)] public igVec3fMetaField _destination = new();
    }
}
