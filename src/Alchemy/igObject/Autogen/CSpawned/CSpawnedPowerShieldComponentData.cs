namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CSpawnedPowerShieldComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _timeBeforeWarning;
        [FieldAttr(ctr: 24)] public float _duration;
        [FieldAttr(ctr: 28)] public float _speed;
        [FieldAttr(ctr: 32)] public float _fakeGravity;
        [FieldAttr(ctr: 36)] public float _shrinkDuration;
        [FieldAttr(ctr: 40)] public igHandleMetaField _shieldAttach = new();
        [FieldAttr(ctr: 48)] public float _lifetime;
        [FieldAttr(ctr: 52)] public float _offsetFromWall;
        [FieldAttr(ctr: 56)] public float _raycastRadius;
    }
}
