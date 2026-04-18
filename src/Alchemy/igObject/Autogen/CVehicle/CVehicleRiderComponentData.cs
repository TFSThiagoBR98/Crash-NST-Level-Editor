namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVehicleRiderComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleRiderData? _driverData;
        [FieldAttr(nst: 32)] public CVehicleRiderData? _passengerData;
    }
}
