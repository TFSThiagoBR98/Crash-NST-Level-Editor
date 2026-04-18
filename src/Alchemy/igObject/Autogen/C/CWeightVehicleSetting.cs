namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 4)]
    public class CWeightVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _coastingTimeFromMaxForwardSpeed = 0.3f;
        [FieldAttr(nst: 28, ctr: 24)] public float _brakingTimeFromMaxForwardSpeed = 3.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _brakingTimeFromMaxForwardSpeedArenaMode = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _airCoastingTimeFromMaxForwardSpeed = 15.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _mass = 1000.0f;
    }
}
