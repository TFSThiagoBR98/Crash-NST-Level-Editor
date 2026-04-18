namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CSpawnedBeakerComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _timeBeforeCanHitUser;
        [FieldAttr(ctr: 24)] public float _timeBeforeCanHitWorld;
        [FieldAttr(ctr: 28)] public float _victimPoisonedTime;
        [FieldAttr(ctr: 32)] public CKartMaxSpeedModifierData? _victimPoisonedSpeedModifier;
        [FieldAttr(ctr: 40)] public float _lobHeight;
        [FieldAttr(ctr: 44)] public float _lobLength;
        [FieldAttr(ctr: 48)] public float _lobForwardSpeed;
        [FieldAttr(ctr: 52)] public igVec3fMetaField _groundOffset = new();
        [FieldAttr(ctr: 64)] public float _lookForGroundDistance;
        [FieldAttr(ctr: 68)] public float _lookForWallDistance;
        [FieldAttr(ctr: 72)] public float _maxFallDistance;
        [FieldAttr(ctr: 80)] public igHandleMetaField _respawnMaterial = new();
        [FieldAttr(ctr: 88)] public float _offsetFromWall;
        [FieldAttr(ctr: 92)] public bool _isThrown;
    }
}
