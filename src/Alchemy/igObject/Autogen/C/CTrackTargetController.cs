namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CTrackTargetController : CBaseMovementController
    {
        [FieldAttr(ctr: 48)] public float _acceleration;
        [FieldAttr(ctr: 52)] public float _decceleration;
        [FieldAttr(ctr: 56)] public float _maxSpeed;
        [FieldAttr(ctr: 60)] public igVec3fMetaField _currentVelocity = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _target = new();
        [FieldAttr(ctr: 80)] public ETrackRepell _tracking;
        [FieldAttr(ctr: 84)] public igVec3fMetaField _offset = new();
    }
}
