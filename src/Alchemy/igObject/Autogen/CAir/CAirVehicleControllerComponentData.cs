namespace Alchemy
{
    [ObjectAttr(nst: 2672, align: 8)]
    public class CAirVehicleControllerComponentData : CBaseAirControllerComponentData
    {
        [FieldAttr(nst: 2288)] public float _hardStickThreshold = 0.89999998f;
        [FieldAttr(nst: 2292)] public float _yawMaxAngle = 50.0f;
        [FieldAttr(nst: 2296)] public float _yawMinAngle = 20.0f;
        [FieldAttr(nst: 2300)] public igVfxRangedCurveMetaField _yawTurningSpeedCurve = new();
        [FieldAttr(nst: 2384)] public igVfxRangedCurveMetaField _pitchToYawTurnAngleReduction = new();
        [FieldAttr(nst: 2468)] public float _pitchMaxAngle = 60.0f;
        [FieldAttr(nst: 2472)] public float _pitchMinAngle = 30.0f;
        [FieldAttr(nst: 2476)] public float _pitchLockedThreshold = 5.0f;
        [FieldAttr(nst: 2480)] public igVfxRangedCurveMetaField _pitchTurningSpeedCurve = new();
        [FieldAttr(nst: 2564)] public float _pitchDeadZone = 10.0f;
        [FieldAttr(nst: 2568)] public float _pitchDampingFactor = 10.0f;
        [FieldAttr(nst: 2572)] public bool _pitchAutoCenter = true;
        [FieldAttr(nst: 2576)] public float _rollAngleSlowSpeed = 60.0f;
        [FieldAttr(nst: 2580)] public float _rollAngleFastSpeed = 30.0f;
        [FieldAttr(nst: 2584)] public float _rollDeadZone = 0.1f;
        [FieldAttr(nst: 2588)] public float _rollDampingFactor = 10.0f;
        [FieldAttr(nst: 2592)] public float _rollDriftAngleMax = 90.0f;
        [FieldAttr(nst: 2596)] public float _driftAccelerationTurnSpeedScale = 0.2f;
        [FieldAttr(nst: 2600)] public float _driftCoastingTurnSpeedScale = 1.0f;
        [FieldAttr(nst: 2604)] public bool _useVehicleForward;
        [FieldAttr(nst: 2608)] public float _reticleLockDistance = 0.2f;
        [FieldAttr(nst: 2612)] public float _reticleDropDistance = 0.64999998f;
        [FieldAttr(nst: 2616)] public float _reticleLockMinSpeed = 0.015f;
        [FieldAttr(nst: 2620)] public float _reticleTravelSpeed = 1.0f;
        [FieldAttr(nst: 2624)] public float _reticleMaxTravelSpeed = 1.875f;
        [FieldAttr(nst: 2628)] public float _reticleDeadzoneSpeed = 1.0f;
        [FieldAttr(nst: 2632)] public float _horizontalScreenEdgeOffsetSlowSpeed = 0.44999999f;
        [FieldAttr(nst: 2636)] public float _verticalScreenEdgeOffsetSlowSpeed = 0.3f;
        [FieldAttr(nst: 2640)] public float _horizontalScreenEdgeOffsetFastSpeed = 0.1f;
        [FieldAttr(nst: 2644)] public float _verticalScreenEdgeOffsetFastSpeed = 0.1f;
        [FieldAttr(nst: 2648)] public float _reticleDistanceInFront = 16000.0f;
        [FieldAttr(nst: 2652)] public bool _reticleMovementIsRawInput = true;
        [FieldAttr(nst: 2656)] public float _maxTargetingDistance = 15000.0f;
        [FieldAttr(nst: 2660)] public float _targetSearchPadding = 70.0f;
        [FieldAttr(nst: 2664)] public float _linSideDragDampingFactor = 0.4f;
    }
}
