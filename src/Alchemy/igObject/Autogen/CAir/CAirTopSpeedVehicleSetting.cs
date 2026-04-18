namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 4)]
    public class CAirTopSpeedVehicleSetting : CTopSpeedVehicleSetting
    {
        [FieldAttr(nst: 48, ctr: 44)] public float _airBrakingSpeedScale = 0.1f;
        [FieldAttr(nst: 52, ctr: 48)] public float _airBrakingSpeedScaleOverride = 0.1f;
        [FieldAttr(nst: 56, ctr: 52)] public float _cameraFOVMax = 115.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _cameraFOVMin = 100.0f;
        [FieldAttr(nst: 64)] public float _arenaModeForwardSpeedScale_1 = 0.66f;
        [FieldAttr(nst: 68)] public float _stickOnlyMaxForwardSpeedDualSpeedLinearMode_1 = 1000.0f;
        [FieldAttr(nst: 72)] public float _stickOnlyMaxForwardSpeedDualSpeedMode_1 = 1000.0f;
        [FieldAttr(ctr: 60)] public float _arenaModeForwardSpeedScale2;
        [FieldAttr(ctr: 64)] public float _stickOnlyMaxForwardSpeedDualSpeedLinearMode2;
        [FieldAttr(ctr: 68)] public float _stickOnlyMaxForwardSpeedDualSpeedMode2;
    }
}
