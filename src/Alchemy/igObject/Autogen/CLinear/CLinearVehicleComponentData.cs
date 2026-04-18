namespace Alchemy
{
    [ObjectAttr(nst: 552, align: 8)]
    public class CLinearVehicleComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _controlVehicleMovement = true;
        [FieldAttr(nst: 28)] public igVec2fMetaField _translationAcceleration = new();
        [FieldAttr(nst: 36)] public igVec2fMetaField _translationDeceleration = new();
        [FieldAttr(nst: 44)] public igVec2fMetaField _translationSpeedMax = new();
        [FieldAttr(nst: 52)] public float _speedBoostAcceleration = 9000.0f;
        [FieldAttr(nst: 56)] public float _speedBoostDeceleration = 4000.0f;
        [FieldAttr(nst: 60)] public float _speedBrakeAcceleration = 8000.0f;
        [FieldAttr(nst: 64)] public float _speedBrakeDeceleration = 4000.0f;
        [FieldAttr(nst: 68)] public float _boostHandlingModifier = 1.29999995f;
        [FieldAttr(nst: 72)] public float _brakeHandlingModifier = 0.4f;
        [FieldAttr(nst: 76)] public float _boostTimeMax = 1.2f;
        [FieldAttr(nst: 80)] public float _boostCooldownTime = 2.0f;
        [FieldAttr(nst: 84)] public float _boostDistanceMax;
        [FieldAttr(nst: 88)] public float _brakeDistanceMax;
        [FieldAttr(nst: 92)] public float _boostVelocityMax = 12000.0f;
        [FieldAttr(nst: 96)] public float _brakeVelocityDecreaseMax = 2000.0f;
        [FieldAttr(nst: 100)] public EXBUTTON _boostButton = EXBUTTON.R2;
        [FieldAttr(nst: 104)] public EXBUTTON _brakeButton = EXBUTTON.L2;
        [FieldAttr(nst: 108)] public igVec3fMetaField _rotationAnglesMax = new();
        [FieldAttr(nst: 120)] public EigEaseType _rotationAtTranslationMaxEaseType;
        [FieldAttr(nst: 124)] public float _rotationDampingFactor = 0.3f;
        [FieldAttr(nst: 128)] public bool _doTargeting = true;
        [FieldAttr(nst: 136)] public CQueryFilter? _filterTargets;
        [FieldAttr(nst: 144)] public float _targetingDistance = 2000.0f;
        [FieldAttr(nst: 148)] public float _primaryReticleScale = 1.0f;
        [FieldAttr(nst: 152)] public float _targetingVerticleOffset;
        [FieldAttr(nst: 156)] public float _maxTargetingAcquireDistance = 2.0f;
        [FieldAttr(nst: 160)] public float _targetingAcquireRadius = 50.0f;
        [FieldAttr(nst: 164)] public float _targetingDropDistance = 200.0f;
        [FieldAttr(nst: 168)] public float _targetingClampPadding = 10.0f;
        [FieldAttr(nst: 172)] public float _targetingMaxSeparationDepth = 2000.0f;
        [FieldAttr(nst: 176)] public float _targetingMinKeepTargetDepth = 1000.0f;
        [FieldAttr(nst: 184)] public igHandleMetaField _primaryReticleEffectNoTarget = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _primaryReticleEffectWithTarget = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _lockedReticleEffect = new();
        [FieldAttr(nst: 208)] public CBoltPoint? _lockedReticleBolt;
        [FieldAttr(nst: 216)] public bool _targetingSquareStickInput = true;
        [FieldAttr(nst: 220)] public float _targetLocalVersusSreenSpaceWeight;
        [FieldAttr(nst: 224)] public bool _landTargetingHorizontalUsePositionNotAngle;
        [FieldAttr(nst: 228)] public float _landTargetingYawMax = 40.0f;
        [FieldAttr(nst: 232)] public float _landTargetingTimeToYawMax = 0.3f;
        [FieldAttr(nst: 236)] public float _landTargetingTimeToYawZero = 0.5f;
        [FieldAttr(nst: 240)] public igVfxRangedCurveMetaField _landTargetingYawAccelCurve = new();
        [FieldAttr(nst: 324)] public bool _landTargetingVerticalUsePositionNotAngle;
        [FieldAttr(nst: 325)] public bool _landTargetingVerticalAutoFall;
        [FieldAttr(nst: 328)] public float _landTargetingPitchMax = 40.0f;
        [FieldAttr(nst: 332)] public float _landTargetingPitchUpTime = 0.5f;
        [FieldAttr(nst: 336)] public float _landTargetingPitchDownTime = 0.5f;
        [FieldAttr(nst: 340)] public bool _landTargetingUseVerticalScreenSpace;
        [FieldAttr(nst: 344)] public float _landTargetingVerticalSpeed = 100.0f;
        [FieldAttr(nst: 348)] public float _landTargetingVerticalAccelTime;
        [FieldAttr(nst: 352)] public float _landTargetingVerticalMaxDistanceBelow;
        [FieldAttr(nst: 356)] public float _landTargetingVerticalMarginFromTop;
        [FieldAttr(nst: 360)] public float _landTargetingVerticalFallBackDownTime;
        [FieldAttr(nst: 364)] public float _landTargetingVerticalFallBackDownAmount;
        [FieldAttr(nst: 368)] public igVfxRangedCurveMetaField _landTargetingVerticalFallBackDownScaleCurve = new();
        [FieldAttr(nst: 452)] public float _landTargetingVerticalFallBackUpTime;
        [FieldAttr(nst: 456)] public float _landTargetingVerticalFallBackUpAmount;
        [FieldAttr(nst: 460)] public igVfxRangedCurveMetaField _landTargetingVerticalFallBackUpScaleCurve = new();
        [FieldAttr(nst: 544)] public float _initialRotationCorrectionTime = 0.5f;
    }
}
