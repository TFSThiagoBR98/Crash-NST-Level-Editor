namespace Alchemy
{
    [ObjectAttr(nst: 336, align: 8)]
    public class CCommonVehicleBehaviorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _autoDetermineDriveState;
        [FieldAttr(nst: 25)] public bool _autoDetermineAccelerateState = true;
        [FieldAttr(nst: 26)] public bool _autoDriveIgnoreZVelocity;
        [FieldAttr(nst: 28)] public float _autoDriveIdleSpeed = 100.0f;
        [FieldAttr(nst: 32)] public float _autoDriveRequiredFullSpeedRatio = 0.89999998f;
        [FieldAttr(nst: 40)] public string? _idleEvent = "Idle";
        [FieldAttr(nst: 48)] public string? _idleState = "Idle";
        [FieldAttr(nst: 56)] public string? _slowSpeedEvent = "Drive_Slow";
        [FieldAttr(nst: 64)] public string? _slowSpeedState = "Drive_Slow";
        [FieldAttr(nst: 72)] public string? _maxSpeedEvent = "Drive_FullSpeed";
        [FieldAttr(nst: 80)] public string? _maxSpeedState = "Drive_FullSpeed";
        [FieldAttr(nst: 88)] public string? _reverseEvent = "Drive_Reverse";
        [FieldAttr(nst: 96)] public string? _reverseState = "Drive_Reverse";
        [FieldAttr(nst: 104)] public string? _brakeBeginEvent = "BrakingFadeIn";
        [FieldAttr(nst: 112)] public string? _brakeEndEvent = "BrakingFadeOut";
        [FieldAttr(nst: 120)] public string? _brakeState = "Braking";
        [FieldAttr(nst: 128)] public string? _brakeStopBeginEvent = "Brake_Stop";
        [FieldAttr(nst: 136)] public string? _brakeStopState = "Brake_Stop";
        [FieldAttr(nst: 144)] public string? _accelerateBeginEvent = "AccelerateFadeIn";
        [FieldAttr(nst: 152)] public string? _accelerateEndEvent = "AccelerateFadeOut";
        [FieldAttr(nst: 160)] public string? _accelerateState = "Accelerate";
        [FieldAttr(nst: 168)] public string? _diveEvent = "Dive";
        [FieldAttr(nst: 176)] public string? _diveState = "Submerge";
        [FieldAttr(nst: 184)] public string? _jumpEvent = "Jump";
        [FieldAttr(nst: 192)] public string? _halfPipeJumpEvent = "Jump";
        [FieldAttr(nst: 200)] public string? _halfPipeFallEvent = "Fall";
        [FieldAttr(nst: 208)] public string? _jumpState = "Jump";
        [FieldAttr(nst: 216)] public string? _fallEvent = "Fall";
        [FieldAttr(nst: 224)] public string? _fallState = "Falling";
        [FieldAttr(nst: 232)] public string? _landEvent = "Land";
        [FieldAttr(nst: 240)] public string? _deathState = "Death";
        [FieldAttr(nst: 248)] public string? _outroState = "Outro";
        [FieldAttr(nst: 256)] public string? _driftBeginEvent = "DriftFadeIn";
        [FieldAttr(nst: 264)] public string? _driftEndEvent = "DriftFadeOut";
        [FieldAttr(nst: 272)] public string? _driftState = "Drift";
        [FieldAttr(nst: 280)] public string? _boostBeginEvent = "Boost_Beginning";
        [FieldAttr(nst: 288)] public float _brakeRequiredSpeedRatio = 0.1f;
        [FieldAttr(nst: 292)] public float _brakeStopSpeedRatio = 0.1f;
        [FieldAttr(nst: 296)] public float _reverseRequiredSpeedRatio = 0.1f;
        [FieldAttr(nst: 304)] public igHandleMetaField _velocityTriggeredVfx = new();
        [FieldAttr(nst: 312)] public float _velocityToTriggervfx = 2000.0f;
        [FieldAttr(nst: 316)] public float _minLandHardVelocity = 2000.0f;
        [FieldAttr(nst: 320)] public bool _updateTurningBlend = true;
        [FieldAttr(nst: 324)] public float _turningBlendChangePerSecond = -1.0f;
        [FieldAttr(nst: 328)] public bool _flipTurnWhenDrifting;
    }
}
