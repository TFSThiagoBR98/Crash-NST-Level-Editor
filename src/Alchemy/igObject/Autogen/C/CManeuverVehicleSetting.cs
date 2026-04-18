namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 4)]
    public class CManeuverVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _airTurningSpeed = 48.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _arenaModeAirTurningSpeedScale = 5.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _turningSpeedFactorForRelativeControls = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _surfaceTurningSpeed = 96.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _surfaceTurningSpeedWhileBoostingScale = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _arenaModeSurfaceTurningSpeedScale = 1.25f;
        [FieldAttr(nst: 48, ctr: 44)] public float _arenaModeSurfaceTurningSpeedScaleWhileReversing = 1.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _accelerationTimeToMaxTurningSpeed = 0.2f;
        [FieldAttr(nst: 56, ctr: 52)] public float _accelerationTimeToMaxTurningSpeedArena = 0.69999999f;
        [FieldAttr(nst: 60, ctr: 56)] public float _coastingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 64, ctr: 60)] public float _brakingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 68, ctr: 64)] public float _maxLinearModeTurningPushSurface = 2500.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _maxLinearModeTurningPushAir = 2500.0f;
        [FieldAttr(nst: 76, ctr: 72)] public float _rollTurnRate = 130.0f;
    }
}
