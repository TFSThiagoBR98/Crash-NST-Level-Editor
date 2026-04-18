namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CSpawnedInvincibilityMaskComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _duration;
        [FieldAttr(ctr: 24)] public float _almostDoneWarningDuration;
        [FieldAttr(ctr: 32)] public CEntity? _maskData;
        [FieldAttr(ctr: 40)] public CEntity? _rotatingModelData;
        [FieldAttr(ctr: 48)] public igHandleMetaField _maskAttach = new();
        [FieldAttr(ctr: 56)] public CKartMaxSpeedModifierData? _speedBoost;
    }
}
