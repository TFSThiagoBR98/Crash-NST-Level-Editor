namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 8)]
    public class CMultipleVehicleModeFilter : CBaseVehicleModeFilter
    {
        [FieldAttr(nst: 16)] public CVehicleModeFilterList? _vehicleModeFilters;
    }
}
