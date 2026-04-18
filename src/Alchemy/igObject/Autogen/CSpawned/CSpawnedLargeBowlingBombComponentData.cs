namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CSpawnedLargeBowlingBombComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public igVec3fMetaField _initialRotation = new();
        [FieldAttr(ctr: 32)] public igVec3fMetaField _rotationPerSecond = new();
        [FieldAttr(ctr: 44)] public float _delayBeforeAim;
        [FieldAttr(ctr: 48)] public float _turningSpeed;
        [FieldAttr(ctr: 52)] public float _maxTargettingAngle;
        [FieldAttr(ctr: 56)] public float _raycastRadius;
        [FieldAttr(ctr: 60)] public float _offsetFromWall;
        [FieldAttr(ctr: 64)] public float _fallSpeedIncrement;
        [FieldAttr(ctr: 68)] public float _deletionRange;
        [FieldAttr(ctr: 72)] public float _speed;
        [FieldAttr(ctr: 76)] public float _lifetime;
        [FieldAttr(ctr: 80)] public float _backwardSpeedModifier;
        [FieldAttr(ctr: 84)] public float _explosionRadius;
        [FieldAttr(ctr: 88)] public float _testGroundAboveOffset;
        [FieldAttr(ctr: 92)] public float _testGroundBelowOffset;
        [FieldAttr(ctr: 96)] public igHandleMetaField _respawnMaterial = new();
        [FieldAttr(ctr: 104)] public bool _isLaunchedBackwards;
    }
}
