namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 4)]
    public class CTopSpeedVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _maxForwardSpeed = 3600.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _maxReverseSpeed = -2500.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _arenaModeForwardSpeedScale = 0.66f;
        [FieldAttr(nst: 36, ctr: 32)] public float _stickOnlyMaxForwardSpeedDualSpeedLinearMode = 1000.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _stickOnlyMaxForwardSpeedDualSpeedMode = 1000.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _coastingSpeedScale = 0.5f;
    }
}
