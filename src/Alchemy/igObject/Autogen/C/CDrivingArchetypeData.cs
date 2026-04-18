namespace Alchemy
{
    [ObjectAttr(ctr: 608, align: 8)]
    public class CDrivingArchetypeData : igObject
    {
        [FieldAttr(ctr: 16)] public CKartAngularVelocityData? _angularAccelerateVelocityData;
        [FieldAttr(ctr: 24)] public CKartAngularVelocityData? _angularNeutralVelocityData;
        [FieldAttr(ctr: 32)] public CKartAngularVelocityData? _angularBrakingVelocityData;
        [FieldAttr(ctr: 40)] public CKartAngularVelocityData? _angularReverseVelocityData;
        [FieldAttr(ctr: 48)] public CKartAngularVelocityData? _angularUpwardInAirVelocityData;
        [FieldAttr(ctr: 56)] public CKartAngularVelocityData? _angularInAirVelocityData;
        [FieldAttr(ctr: 64)] public CKartAngularVelocityData? _angularInAirBrakingVelocityData;
        [FieldAttr(ctr: 72)] public float _inAirApexDownwardSpeedThreshold;
        [FieldAttr(ctr: 80)] public CKartAngularVelocityData? _angularUpwardHoppingVelocityData;
        [FieldAttr(ctr: 88)] public CKartAngularVelocityData? _angularHoppingVelocityData;
        [FieldAttr(ctr: 96)] public float _hoppingApexDownwardSpeedThreshold;
        [FieldAttr(ctr: 104)] public CKartLinearVelocityData? _forwardLinearVelocityData;
        [FieldAttr(ctr: 112)] public CKartLinearVelocityData? _forwardInAirLinearVelocityData;
        [FieldAttr(ctr: 120)] public CKartLinearVelocityData? _backwardLinearVelocityData;
        [FieldAttr(ctr: 128)] public float _turnInputVelocityDamperIncreaseDelay;
        [FieldAttr(ctr: 132)] public float _turnInputVelocityDamperInputTreshold;
        [FieldAttr(ctr: 136)] public float _turnInputVelocityMaxDamping;
        [FieldAttr(ctr: 140)] public float _turnInputDamperIncreaseRate;
        [FieldAttr(ctr: 144)] public float _turnInputDamperDecreaseRate;
        [FieldAttr(ctr: 152)] public CKartCombinedBrakeAndAccelData? _combinedBrakeAndAccelData;
        [FieldAttr(ctr: 160)] public float _forwardBrakeReverseTurnSpeedLossMultiplier;
        [FieldAttr(ctr: 164)] public float _damageDecelerationRateAddedRatio;
        [FieldAttr(ctr: 168)] public CKartDriftData? _driftData;
        [FieldAttr(ctr: 176)] public float _jumpImpulse;
        [FieldAttr(ctr: 180)] public float _jumpImpulsePreserveTime;
        [FieldAttr(ctr: 184)] public igVfxRangedCurveMetaField _jumpImpulseUpSlopeMultiplier = new();
        [FieldAttr(ctr: 268)] public igVfxRangedCurveMetaField _jumpImpulseDownSlopeMultiplier = new();
        [FieldAttr(ctr: 352)] public float _jumpMinimalSpamInterval;
        [FieldAttr(ctr: 356)] public float _jumpInputBufferTime;
        [FieldAttr(ctr: 360)] public float _jumpAnticipationTime;
        [FieldAttr(ctr: 364)] public float _jumpLostGroundAllowTime;
        [FieldAttr(ctr: 368)] public float _trickJumpImpulse;
        [FieldAttr(ctr: 372)] public float _trickJumpProjectilingAddedImpulse;
        [FieldAttr(ctr: 376)] public float _trickJumpImpulsePreserveTime;
        [FieldAttr(ctr: 380)] public igVfxRangedCurveMetaField _trickJumpImpulseUpSlopeMultiplier = new();
        [FieldAttr(ctr: 464)] public igVfxRangedCurveMetaField _trickJumpImpulseDownSlopeMultiplier = new();
        [FieldAttr(ctr: 548)] public float _trickJumpMinSpeedRatio;
        [FieldAttr(ctr: 552)] public float _trickJumpLookAheadTime;
        [FieldAttr(ctr: 556)] public float _trickJumpAddedQueryHeight;
        [FieldAttr(ctr: 560)] public float _trickJumpDownCheckLength;
        [FieldAttr(ctr: 564)] public float _trickJumpDownCheckLengthUpSlope;
        [FieldAttr(ctr: 568)] public float _boostCrushFakeImpulse;
        [FieldAttr(ctr: 572)] public float _boostCrushMinDeltaSpeed;
        [FieldAttr(ctr: 576)] public float _bodyMaxTurnAnimRatio;
        [FieldAttr(ctr: 580)] public float _bodyYawAnimLerpSpeedActiveFactor;
        [FieldAttr(ctr: 584)] public float _bodyYawAnimLerpSpeedInactiveFactor;
        [FieldAttr(ctr: 588)] public float _driftLeftAnimRatioMidPoint;
        [FieldAttr(ctr: 592)] public float _driftRightAnimRatioMidPoint;
        [FieldAttr(ctr: 596)] public float _driftBodyMaxTurnAnimRatio;
        [FieldAttr(ctr: 600)] public float _driftBodyMaxTurnCounterAnimRatio;
        [FieldAttr(ctr: 604)] public float _driftBodyYawAnimLerpSpeedFactor;
    }
}
