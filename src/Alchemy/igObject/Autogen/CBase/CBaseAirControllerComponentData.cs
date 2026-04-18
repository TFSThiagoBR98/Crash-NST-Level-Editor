namespace Alchemy
{
    [ObjectAttr(nst: 2288, align: 8)]
    public class CBaseAirControllerComponentData : CBaseVehicleControllerComponentData
    {
        [FieldAttr(nst: 1776)] public igHandleMetaField _softCollisionMaterial = new();
        [FieldAttr(nst: 1784)] public float _softCollisionRadius = 1000.0f;
        [FieldAttr(nst: 1788)] public float _softCollisionSpeedDivider = 200.0f;
        [FieldAttr(nst: 1792)] public float _softCollisionImpulse = 350.0f;
        [FieldAttr(nst: 1796)] public float _softCollisionMinForwardVel = 2000.0f;
        [FieldAttr(nst: 1800)] public float _softCollisionForwardImpulse = 200.0f;
        [FieldAttr(nst: 1804)] public float _softCollisionStopTurnAngle = 30.0f;
        [FieldAttr(nst: 1808)] public igHandleMetaField _softCollisionVfxToSpawn = new();
        [FieldAttr(nst: 1816)] public float _softCollisionVfxSpawnOffset = 200.0f;
        [FieldAttr(nst: 1820)] public float _speedIntensityDampingFactor = 0.5f;
        [FieldAttr(nst: 1824)] public igVfxRangedCurveMetaField _accelerationToMaxSpeedIntensityCurve = new();
        [FieldAttr(nst: 1908)] public igVfxRangedCurveMetaField _decelerationToCoastingSpeedIntensityCurve = new();
        [FieldAttr(nst: 1992)] public igVfxRangedCurveMetaField _accelerationToCoastingSpeedIntensityCurve = new();
        [FieldAttr(nst: 2076)] public igVfxRangedCurveMetaField _decelerationToBrakingSpeedIntensityCurve = new();
        [FieldAttr(nst: 2160)] public float _softCollisionBoostImpulseMultiplier = 8.0f;
        [FieldAttr(nst: 2164)] public float _softCollisionBoostForwardImpulseMultiplier = 2.0f;
        [FieldAttr(nst: 2168)] public float _softCollisionBoostTurnMultiplier = 2.0f;
        [FieldAttr(nst: 2172)] public bool _useBrakingSpeedScaleOverride;
        [FieldAttr(nst: 2176)] public float _barrelRollPushForce = 3500.0f;
        [FieldAttr(nst: 2180)] public float _barrelRollTime = 1.0f;
        [FieldAttr(nst: 2184)] public float _barrelRollCooldownTime = 0.1f;
        [FieldAttr(nst: 2188)] public igVfxRangedCurveMetaField _barrelRollPushCurve = new();
        [FieldAttr(nst: 2272)] public float _inputAxisLockout = 0.89999998f;
        [FieldAttr(nst: 2276)] public float _inputAxisReduction = 0.5f;
        [FieldAttr(nst: 2280)] public bool _showReticle = true;
        [FieldAttr(nst: 2281)] public bool _reticleDrivesInput;
        [FieldAttr(nst: 2282)] public bool _useAnalogSteeringFix = true;
        [FieldAttr(nst: 2284)] public EXBUTTON _jumpButtonSecondary = EXBUTTON.JUMP;
    }
}
