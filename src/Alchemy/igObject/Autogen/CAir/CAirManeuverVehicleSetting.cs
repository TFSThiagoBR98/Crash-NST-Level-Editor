namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 176, align: 4)]
    public class CAirManeuverVehicleSetting : CManeuverVehicleSetting
    {
        [FieldAttr(nst: 80, ctr: 76)] public float _pitchUpMaxTurningSpeed = 240.0f;
        [FieldAttr(nst: 84, ctr: 80)] public float _pitchUpMinTurningSpeed = 240.0f;
        [FieldAttr(nst: 88, ctr: 84)] public float _pitchDownMaxTurningSpeed = 240.0f;
        [FieldAttr(nst: 92, ctr: 88)] public float _pitchDownMinTurningSpeed = 240.0f;
        [FieldAttr(nst: 96, ctr: 92)] public float _yawMaxTurningSpeed = 240.0f;
        [FieldAttr(nst: 100, ctr: 96)] public float _yawMinTurningSpeed = 240.0f;
        [FieldAttr(nst: 104, ctr: 100)] public float _rollMaxTurnRate = 5.0f;
        [FieldAttr(nst: 108, ctr: 104)] public float _rollMinTurnRate = 5.0f;
        [FieldAttr(nst: 112, ctr: 108)] public float _airAcceleratingDriftSideDragScale = 0.005f;
        [FieldAttr(nst: 116, ctr: 112)] public float _airCoastingDriftSideDragScale = 0.5f;
        [FieldAttr(nst: 120, ctr: 116)] public float _pitchUpAccelerationTimeToMaxTurningSpeed = 0.2f;
        [FieldAttr(nst: 124, ctr: 120)] public float _pitchUpCoastingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 128, ctr: 124)] public float _pitchUpBrakingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 132, ctr: 128)] public float _pitchDownAccelerationTimeToMaxTurningSpeed = 0.2f;
        [FieldAttr(nst: 136, ctr: 132)] public float _pitchDownCoastingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 140, ctr: 136)] public float _pitchDownBrakingTimeFromMaxTurningSpeed = 0.1f;
        [FieldAttr(nst: 144)] public float _airTurningSpeed_1 = 48.0f;
        [FieldAttr(nst: 148)] public float _arenaModeAirTurningSpeedScale_1 = 5.0f;
        [FieldAttr(nst: 152)] public float _surfaceTurningSpeed_1 = 96.0f;
        [FieldAttr(nst: 156)] public float _arenaModeSurfaceTurningSpeedScale_1 = 1.25f;
        [FieldAttr(nst: 160)] public float _accelerationTimeToMaxTurningSpeed_1 = 0.2f;
        [FieldAttr(nst: 164)] public float _coastingTimeFromMaxTurningSpeed_1 = 0.1f;
        [FieldAttr(nst: 168)] public float _brakingTimeFromMaxTurningSpeed_1 = 0.1f;
        [FieldAttr(nst: 172)] public float _maxLinearModeTurningPushSurface_1 = 2500.0f;
        [FieldAttr(nst: 176)] public float _maxLinearModeTurningPushAir_1 = 2500.0f;
        [FieldAttr(ctr: 140)] public float _airTurningSpeed2;
        [FieldAttr(ctr: 144)] public float _arenaModeAirTurningSpeedScale2;
        [FieldAttr(ctr: 148)] public float _surfaceTurningSpeed2;
        [FieldAttr(ctr: 152)] public float _arenaModeSurfaceTurningSpeedScale2;
        [FieldAttr(ctr: 156)] public float _accelerationTimeToMaxTurningSpeed2;
        [FieldAttr(ctr: 160)] public float _coastingTimeFromMaxTurningSpeed2;
        [FieldAttr(ctr: 164)] public float _brakingTimeFromMaxTurningSpeed2;
        [FieldAttr(ctr: 168)] public float _maxLinearModeTurningPushSurface2;
        [FieldAttr(ctr: 172)] public float _maxLinearModeTurningPushAir2;
    }
}
