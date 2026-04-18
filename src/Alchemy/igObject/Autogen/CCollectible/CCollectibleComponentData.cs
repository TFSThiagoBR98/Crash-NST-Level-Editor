namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 200, align: 8)]
    public class CCollectibleComponentData : igComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public ECollectibleType _collectibleType = ECollectibleType.eCT_Money;
        [FieldAttr(nst: 28, ctr: 20)] public float _awardValue = 50.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _alternateAwardValue = 1.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _attractRadius = 125.0f;
        [FieldAttr(nst: 40, ctr: 32)] public float _attractAcceleration = 2000.0f;
        [FieldAttr(nst: 44, ctr: 36)] public bool _isShrinkable = true;
        [FieldAttr(nst: 48, ctr: 40)] public float _attractSpeed = 350.0f;
        [FieldAttr(nst: 52, ctr: 44)] public bool _killOnCollected = true;
        [FieldAttr(nst: 56, ctr: 48)] public float _collectRadius = 10.0f;
        [FieldAttr(nst: 60, ctr: 52)] public igRangedFloatMetaField _autoCollectDelay = new();
        [FieldAttr(nst: 68, ctr: 60)] public bool _disableOnReturnToStartingHeight;
        [FieldAttr(nst: 72, ctr: 64)] public float _sphereShapeRadius = 30.0f;
        [FieldAttr(nst: 80, ctr: 72)] public igHandleMetaField _physicsMotion = new();
        [FieldAttr(nst: 88, ctr: 80)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(nst: 96, ctr: 88)] public uint _collisionFlags = 400;
        [FieldAttr(nst: 104, ctr: 96)] public igHandleMetaField _idleVfx = new();
        [FieldAttr(nst: 112, ctr: 104)] public igHandleMetaField _trailVfx = new();
        [FieldAttr(nst: 120, ctr: 112)] public igHandleMetaField _collectBeginVfx = new();
        [FieldAttr(nst: 128, ctr: 120)] public igHandleMetaField _collectEndVfx = new();
        [FieldAttr(nst: 136, ctr: 128)] public CBoltPoint? _vfxBoltPoint;
        [FieldAttr(nst: 144, ctr: 136)] public bool _collectBeginVfxSpawnAtPosition;
        [FieldAttr(nst: 152, ctr: 144)] public igHandleMetaField _spawnSfx = new();
        [FieldAttr(nst: 160, ctr: 152)] public igHandleMetaField _pickupSfx = new();
        [FieldAttr(nst: 168, ctr: 160)] public string? _heroPickupSfx = null;
        [FieldAttr(nst: 176, ctr: 168)] public igHandleMetaField _collectedSfx = new();
        [FieldAttr(nst: 184, ctr: 176)] public float _collectedRumbleAmount;
        [FieldAttr(nst: 188, ctr: 180)] public float _collectedRumbleDuration;
        [FieldAttr(nst: 192, ctr: 184)] public float _collectedVibrationAmount = 0.3f;
        [FieldAttr(nst: 196, ctr: 188)] public float _collectedVibrationDuration = 0.2f;
        [FieldAttr(nst: 200, ctr: 192)] public ECollectibleWorldModifierCategory _worldModifierCategory = ECollectibleWorldModifierCategory.eCWMC_UseCollectibleDefaults;
    }
}
