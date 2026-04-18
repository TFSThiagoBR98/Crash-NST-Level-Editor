namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CAccelerationVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _accelerationTimeToMaxForwardSpeed = 1.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _airAccelerationTimeToMaxForwardSpeed = 1.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _arenaModeAccelerationTimeScale = 1.0f;
    }
}
