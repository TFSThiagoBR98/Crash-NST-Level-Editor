namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 4)]
    public class CVehicleModeFilter : CBaseVehicleModeFilter
    {
        public enum EVehicleModeFilterType
        {
            eVMFT_VehicleModeRequiredToBeActive = 0,
            eVMFT_VehicleModeRequiredToBeInactive = 1,
        }

        [FieldAttr(nst: 16)] public EVehicleModeFilterType _vehicleModeFilterType;
        [FieldAttr(nst: 20)] public CVehicleComponent.EVehicleMode _vehicleMode;
    }
}
