namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CSpawnedExplosiveCrateComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 17)] public bool _spawnAtStart;
        [FieldAttr(ctr: 20)] public float _timeBeforeExplosion;
        [FieldAttr(ctr: 24)] public float _timeBeforeCanHitUser;
        [FieldAttr(ctr: 28)] public int _jumpNeeded;
        [FieldAttr(ctr: 32)] public float _jumpHeight;
        [FieldAttr(ctr: 36)] public float _jumpLength;
        [FieldAttr(ctr: 40)] public string? _countdownAnimationName;
        [FieldAttr(ctr: 48)] public CKartMaxSpeedModifierData? _slowOnVictim;
        [FieldAttr(ctr: 56)] public float _explosionRadius;
        [FieldAttr(ctr: 60)] public float _attachedExplosionRadius;
        [FieldAttr(ctr: 64)] public float _onGroundScale;
        [FieldAttr(ctr: 68)] public float _attachedScale;
        [FieldAttr(ctr: 72)] public float _rotationInAir;
        [FieldAttr(ctr: 76)] public float _detachNetworkPositionLerp;
    }
}
