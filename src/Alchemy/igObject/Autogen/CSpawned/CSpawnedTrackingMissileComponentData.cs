namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CSpawnedTrackingMissileComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _speed;
        [FieldAttr(ctr: 24)] public float _juicedSpeed;
        [FieldAttr(ctr: 28)] public float _lifetime;
        [FieldAttr(ctr: 32)] public float _delayBeforeAim;
        [FieldAttr(ctr: 36)] public float _turningSpeed;
        [FieldAttr(ctr: 40)] public float _juicedTurningSpeed;
        [FieldAttr(ctr: 44)] public float _closeRange;
        [FieldAttr(ctr: 48)] public float _juicedCloseRange;
        [FieldAttr(ctr: 52)] public igVec3fMetaField _aimOffset = new();
        [FieldAttr(ctr: 64)] public float _maxTargettingAngle;
        [FieldAttr(ctr: 68)] public float _maxReticleDelta;
        [FieldAttr(ctr: 72)] public float _offsetFromWall;
        [FieldAttr(ctr: 76)] public float _raycastRadius;
        [FieldAttr(ctr: 80)] public float _fallSpeedIncrement;
        [FieldAttr(ctr: 88)] public igHandleMetaField _respawnMaterial = new();
        [FieldAttr(ctr: 96)] public float _delayBeforeProximityAiming;
        [FieldAttr(ctr: 100)] public float _distanceToTriggerProximityAiming;
        [FieldAttr(ctr: 104)] public float _proximityTurningSpeed;
    }
}
