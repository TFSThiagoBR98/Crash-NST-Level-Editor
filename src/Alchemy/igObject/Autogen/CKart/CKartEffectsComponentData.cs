namespace Alchemy
{
    [ObjectAttr(ctr: 408, align: 8)]
    public class CKartEffectsComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CKartVfxObjectList? _persistentEffects;
        [FieldAttr(ctr: 24)] public CKartWheelVisualDataList? _wheelVisuals;
        [FieldAttr(ctr: 32)] public float _debugBlendFactor;
        [FieldAttr(ctr: 36)] public igVec3fMetaField _rootOffset = new();
        [FieldAttr(ctr: 48)] public CKartVfxObject? _defaultTrail;
        [FieldAttr(ctr: 56)] public CKartWheelTrailsHashTable? _materialTrails;
        [FieldAttr(ctr: 64)] public float _wheelTrailAccelMaxSpeed;
        [FieldAttr(ctr: 68)] public float _wheelTrailBrakeMinSpeed;
        [FieldAttr(ctr: 72)] public float _wheelieTrailsDuration;
        [FieldAttr(ctr: 80)] public CBoltPoint? _wheelFrontLeft;
        [FieldAttr(ctr: 88)] public CBoltPoint? _wheelFrontRight;
        [FieldAttr(ctr: 96)] public CBoltPoint? _wheelBackLeft;
        [FieldAttr(ctr: 104)] public CBoltPoint? _wheelBackRight;
        [FieldAttr(ctr: 112)] public float _tier1MaxTurboSpeed;
        [FieldAttr(ctr: 116)] public float _tier2MaxTurboSpeed;
        [FieldAttr(ctr: 120)] public float _tier3MaxTurboSpeed;
        [FieldAttr(ctr: 124)] public float _gaugePercentageExhaust;
        [FieldAttr(ctr: 128)] public CBoltPoint? _wheelEffectFrontLeftBolt;
        [FieldAttr(ctr: 136)] public CBoltPoint? _wheelEffectFrontRightBolt;
        [FieldAttr(ctr: 144)] public CBoltPoint? _wheelEffectBackLeftBolt;
        [FieldAttr(ctr: 152)] public CBoltPoint? _wheelEffectBackRightBolt;
        [FieldAttr(ctr: 160)] public float _gaugePercentageWheels;
        [FieldAttr(ctr: 168)] public CKartExhaustEffectsHashTable? _exhaustEffects;
        [FieldAttr(ctr: 176)] public CBoltPoint? _exhaustLeft;
        [FieldAttr(ctr: 184)] public CBoltPoint? _exhaustRight;
        [FieldAttr(ctr: 192)] public CBoltPointHandleList? _additionalExhausts;
        [FieldAttr(ctr: 200)] public CKartExhaustEffectsHashTable? _additionalExhaustEffects;
        [FieldAttr(ctr: 208)] public CKartExhaustEffectsHashTable? _additionalSecondaryExhaustEffects;
        [FieldAttr(ctr: 216)] public float _bubbleHeight;
        [FieldAttr(ctr: 220)] public float _boostFadeOutDuration;
        [FieldAttr(ctr: 224)] public CKartVfxObject? _boostPersistentEffect;
        [FieldAttr(ctr: 232)] public CBoltPoint? _boostPersistentEffectBolt;
        [FieldAttr(ctr: 240)] public float _exhaustVFXVariableSpeedDivider;
        [FieldAttr(ctr: 248)] public CBoltPoint? _surfaceEffectBolt;
        [FieldAttr(ctr: 256)] public CCollisionMaterialHandleList? _waterCollisionMaterial;
        [FieldAttr(ctr: 264)] public CKartVfxObject? _waterSplash;
        [FieldAttr(ctr: 272)] public CKartVfxObject? _waterReverse;
        [FieldAttr(ctr: 280)] public CKartVfxObject? _waterIdle;
        [FieldAttr(ctr: 288)] public CBoltPoint? _waterSplashBoltPoint;
        [FieldAttr(ctr: 296)] public float _waterSplashMinHeight;
        [FieldAttr(ctr: 300)] public float _waterSplashMaxHeight;
        [FieldAttr(ctr: 304)] public float _minimumSpeedForWaterSplash;
        [FieldAttr(ctr: 312)] public CCollisionMaterialHandleList? _mudCollisionMaterial;
        [FieldAttr(ctr: 320)] public CKartVfxObject? _mudSplash;
        [FieldAttr(ctr: 328)] public CKartVfxObject? _mudReverse;
        [FieldAttr(ctr: 336)] public CKartVfxObject? _mudIdle;
        [FieldAttr(ctr: 344)] public CBoltPoint? _mudSplashBoltPoint;
        [FieldAttr(ctr: 352)] public float _mudSplashMinHeight;
        [FieldAttr(ctr: 356)] public float _mudSplashMaxHeight;
        [FieldAttr(ctr: 360)] public float _minimumSpeedForMudSplash;
        [FieldAttr(ctr: 364)] public float _bubbleMaxHeight;
        [FieldAttr(ctr: 368)] public CKartVfxObject? _kartHornVfx;
        [FieldAttr(ctr: 376)] public CBoltPoint? _hornEffectBoltPoint;
        [FieldAttr(ctr: 384)] public float _minAirtimeForLandEffect;
        [FieldAttr(ctr: 392)] public CBoltPoint? _backLeftWheelBoltPoint;
        [FieldAttr(ctr: 400)] public CBoltPoint? _backRightWheelBoltPoint;
    }
}
