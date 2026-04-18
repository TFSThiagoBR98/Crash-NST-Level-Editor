namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class CTractionVehicleSetting : CBaseVehicleSetting
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _slowSurfaceSpeedEffect = 0.5f;
        [FieldAttr(nst: 28, ctr: 24)] public float _slipperySurfaceTurnEffect = 0.5f;
    }
}
