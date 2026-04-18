namespace Alchemy
{
    [ObjectAttr(nst: 1776, align: 8)]
    public class CBaseVehicleControllerComponentData : CEntityComponentData
    {
        public enum EVehicleSteeringMode
        {
            eVSM_None = 0,
            eVSM_Absolute = 1,
            eVSM_Relative = 2,
            eVSM_Count = 3,
        }

        public enum EVehicleAccelerateMode
        {
            eVAM_None = 0,
            eVAM_Button = 1,
            eVAM_Stick = 2,
            eVAM_Auto = 3,
            eVAM_Hybrid = 4,
            eVAM_DualSpeed = 5,
            eVAM_Count = 6,
        }

        [FieldAttr(nst: 24)] public igHandleMetaField _flightControlsInvertedPlayer1 = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _flightControlsInvertedPlayer2 = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _accelerationModeButtonOnlyPlayer1 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _accelerationModeButtonOnlyPlayer2 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _settings = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _racingSettings = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _airArenaSettings = new();
        [FieldAttr(nst: 80)] public bool _calculateCentralBoostValue;
        [FieldAttr(nst: 88)] public CVehicleRubberBanding? _rubberBandingSettings;
        [FieldAttr(nst: 96)] public float _maxDeltaSurfaceAngle = 60.0f;
        [FieldAttr(nst: 100)] public igVfxRangedCurveMetaField _surfaceAnglePowerFactor = new();
        [FieldAttr(nst: 184)] public float _defaultRagdollCollisionResponseTime = 4.0f;
        [FieldAttr(nst: 188)] public igVfxRangedCurveMetaField _surfaceLinearAccelerationVelocityCurve = new();
        [FieldAttr(nst: 272)] public igVfxRangedCurveMetaField _surfaceLinearCoastingVelocityCurve = new();
        [FieldAttr(nst: 356)] public igVfxRangedCurveMetaField _surfaceLinearBrakingVelocityCurve = new();
        [FieldAttr(nst: 440)] public igVfxRangedCurveMetaField _airLinearAccelerationVelocityCurve = new();
        [FieldAttr(nst: 524)] public igVfxRangedCurveMetaField _airLinearCoastingVelocityCurve = new();
        [FieldAttr(nst: 608)] public igVfxRangedCurveMetaField _airLinearBrakingVelocityCurve = new();
        [FieldAttr(nst: 692)] public float _airLinearBrakingTimeMultiplier = 1.0f;
        [FieldAttr(nst: 696)] public EXBUTTON _jumpButton = EXBUTTON.JUMP;
        [FieldAttr(nst: 700)] public EXBUTTON _brakeButton = EXBUTTON.B;
        [FieldAttr(nst: 704)] public EXBUTTON _secondaryBrakeButton = EXBUTTON.BRAKE;
        [FieldAttr(nst: 708)] public bool _canBrakeWhileBoosting;
        [FieldAttr(nst: 712)] public EXBUTTON _driftButton = EXBUTTON.L2;
        [FieldAttr(nst: 716)] public EXBUTTON _driftButtonSecondary = EXBUTTON.L2;
        [FieldAttr(nst: 720)] public CArenaDriftData? _arenaDriftData;
        [FieldAttr(nst: 728)] public CLinearDriftData? _linearDriftData;
        [FieldAttr(nst: 736)] public bool _allowReverse;
        [FieldAttr(nst: 740)] public float _maxForwardSpeedToEnablReverse = 50.0f;
        [FieldAttr(nst: 744)] public float _jumpStopAngleThreshold = 91.0f;
        [FieldAttr(nst: 748)] public float _sapFromVelocityDirectionThreshold = 20.0f;
        [FieldAttr(nst: 752)] public bool _alwaysUseVelocityDirectionInAir;
        [FieldAttr(nst: 756)] public float _maxEnterParkXYVelocity = 50.0f;
        [FieldAttr(nst: 760)] public float _minExitParkXYVelocity = 100.0f;
        [FieldAttr(nst: 764)] public float _maxParkForwardAngle = 60.0f;
        [FieldAttr(nst: 768)] public float _maxParkSideAngle = 60.0f;
        [FieldAttr(nst: 772)] public float _overTopSpeedCorrectionTime = 0.5f;
        [FieldAttr(nst: 776)] public igVfxRangedCurveMetaField _overTopSpeedCorrectionCurve = new();
        [FieldAttr(nst: 860)] public bool _allowBrakingOverTopSpeed;
        [FieldAttr(nst: 864)] public igVfxRangedCurveMetaField _stickAngleTurningPushCurve = new();
        [FieldAttr(nst: 948)] public igVfxRangedCurveMetaField _speedTurningPushCurve = new();
        [FieldAttr(nst: 1032)] public EVehicleSteeringMode _defaultSteeringMode = CBaseVehicleControllerComponentData.EVehicleSteeringMode.eVSM_Absolute;
        [FieldAttr(nst: 1036)] public igVfxRangedCurveMetaField _maxAngularSpeedCurve = new();
        [FieldAttr(nst: 1120)] public float _maxAngularSpeedCurveAbsoluteValue;
        [FieldAttr(nst: 1124)] public igVfxRangedCurveMetaField _angularTurningCurve = new();
        [FieldAttr(nst: 1208)] public float _angularTurningCurveAmplitude = 0.1f;
        [FieldAttr(nst: 1212)] public igVfxRangedCurveMetaField _angularAccelerationVelocityCurve = new();
        [FieldAttr(nst: 1296)] public igVfxRangedCurveMetaField _angularCoastingVelocityCurve = new();
        [FieldAttr(nst: 1380)] public igVfxRangedCurveMetaField _angularBrakingVelocityCurve = new();
        [FieldAttr(nst: 1464)] public float _turningLookAheadTime = 0.25f;
        [FieldAttr(nst: 1468)] public float _minimumSpeedForTurning;
        [FieldAttr(nst: 1472)] public float _steeringOverrideTowardsSplineMultiplier = 10.0f;
        [FieldAttr(nst: 1476)] public float _steeringOverrideTowardsSplineAngularThreshold = 10.0f;
        [FieldAttr(nst: 1480)] public float _steeringOverrideTowardsSplineMaxDuration = 2.0f;
        [FieldAttr(nst: 1484)] public bool _steeringOverrideUseSplineUpAsGuideForRotation;
        [FieldAttr(nst: 1488)] public float _boostOverrideTurningSpeed = 200.0f;
        [FieldAttr(nst: 1492)] public float _boostOverrideTurningLookAheadTime = 0.25f;
        [FieldAttr(nst: 1496)] public float _boostSteeringOverrideDecayScale = 1.0f;
        [FieldAttr(nst: 1500)] public bool _allowRelativeControls;
        [FieldAttr(nst: 1504)] public CShape? _debrisColliderShape;
        [FieldAttr(nst: 1512)] public float highSpeedRatio = 0.75f;
        [FieldAttr(nst: 1520)] public igHandleMetaField _highSpeedForceEffect = new();
        [FieldAttr(nst: 1528)] public CBoltPoint? _highSpeedDebrisLeftWheelBolt;
        [FieldAttr(nst: 1536)] public CBoltPoint? _highSpeedDebrisRightWheelBolt;
        [FieldAttr(nst: 1544)] public CShape? _highSpeedDebrisColliderShape;
        [FieldAttr(nst: 1552)] public string? _raceAiPlayerContactSound = null;
        [FieldAttr(nst: 1560)] public igHandleMetaField _accelerationLowToHighSound = new();
        [FieldAttr(nst: 1568)] public igHandleMetaField _accelerationHighToLowSound = new();
        [FieldAttr(nst: 1576)] public igHandleMetaField _overrideMotionProperties = new();
        [FieldAttr(nst: 1584)] public igVec3fMetaField _localInertiaMultiplier = new();
        [FieldAttr(nst: 1596)] public igVec3fMetaField _centerOfMassLocal = new();
        [FieldAttr(nst: 1608)] public igVec3fMetaField _rootOffset = new();
        [FieldAttr(nst: 1620)] public bool _debug;
        [FieldAttr(nst: 1621)] public bool _dirty;
        [FieldAttr(nst: 1624)] public float _driftOutTime = 0.5f;
        [FieldAttr(nst: 1628)] public EXBUTTON _accelerateButton = EXBUTTON.R2;
        [FieldAttr(nst: 1632)] public EXBUTTON _altAccelerateButton = EXBUTTON.MAX;
        [FieldAttr(nst: 1636)] public float _addedBoostAcceleration = 2000.0f;
        [FieldAttr(nst: 1640)] public float _switchAccelerateModeSpeed = 100.0f;
        [FieldAttr(nst: 1644)] public float _envCollisionSplineLookAheadDistance = 2000.0f;
        [FieldAttr(nst: 1648)] public float _collisionPushCooldown;
        [FieldAttr(nst: 1652)] public float _reorientationRayRadius = 100.0f;
        [FieldAttr(nst: 1656)] public int _reorientationRaycastWaitFrames = 5;
        [FieldAttr(nst: 1660)] public float _epicJumpModelReorientTime = 0.25f;
        [FieldAttr(nst: 1664)] public EXBUTTON _rearViewButton = EXBUTTON.L1;
        [FieldAttr(nst: 1668)] public float _maxSpeedDeltaFollowDistance;
        [FieldAttr(nst: 1672)] public float _maxSpeedDeltaFollowHeight;
        [FieldAttr(nst: 1676)] public float _maxSpeedDeltaFov;
        [FieldAttr(nst: 1680)] public SpeedVfxSpecList? _speedVfxs;
        [FieldAttr(nst: 1688)] public EVehicleAccelerateMode _defaultAccelerationMode = CBaseVehicleControllerComponentData.EVehicleAccelerateMode.eVAM_Button;
        [FieldAttr(nst: 1692)] public float _easySpeedMultiplier = 0.75f;
        [FieldAttr(nst: 1696)] public float _hardSpeedMultiplier = 1.5f;
        [FieldAttr(nst: 1700)] public float _easyBoostMultiplier = 1.25f;
        [FieldAttr(nst: 1704)] public float _hardBoostMultiplier = 0.75f;
        [FieldAttr(nst: 1708)] public bool _useWorldSpaceDragInAir;
        [FieldAttr(nst: 1712)] public float _landLinearSideDrag = 0.1f;
        [FieldAttr(nst: 1716)] public float _landLinearUpDrag = 0.01f;
        [FieldAttr(nst: 1720)] public float _landLinearDownDrag = 0.05f;
        [FieldAttr(nst: 1724)] public float _landAngularPitchRollDrag = 0.15f;
        [FieldAttr(nst: 1728)] public float _airLinearSideDrag = 0.01f;
        [FieldAttr(nst: 1732)] public float _airLinearUpDrag = 0.01f;
        [FieldAttr(nst: 1736)] public float _airLinearDownDrag = 0.01f;
        [FieldAttr(nst: 1740)] public float _airAngularPitchRollDrag = 0.01f;
        [FieldAttr(nst: 1744)] public float _maxKnockawayPitch = 5.0f;
        [FieldAttr(nst: 1748)] public float _maxKnockawayRoll = 5.0f;
        [FieldAttr(nst: 1752)] public float _knockawayResetAngleDamping = 0.1f;
        [FieldAttr(nst: 1756)] public float _maxKnockawayPitchAir = 45.0f;
        [FieldAttr(nst: 1760)] public float _maxKnockawayRollAir = 45.0f;
        [FieldAttr(nst: 1764)] public float _knockawayResetAngleDampingAir = 0.25f;
        [FieldAttr(nst: 1768)] public float _maxKnockawayAngularSpeed = 450.0f;
        [FieldAttr(nst: 1772)] public float _knockawayAirDistanceThreshold = 100.0f;
    }
}
