namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 4)]
    public class CDriftVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _angleThresholdStart = 85.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _angleThresholdStop = 10.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _turningSpeedOverride = 240.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _minimumDriftTime = 0.1f;
        [FieldAttr(nst: 40, ctr: 36)] public float _sideDragScale = 1.0f;
    }
}
