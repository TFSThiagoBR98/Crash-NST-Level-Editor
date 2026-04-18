namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CInputVehicleSettings : igObject
    {
        public enum EInputModificationType
        {
            eIMT_None = 0,
            eIMT_ForceReleased = 1,
            eIMT_ForcePressed = 2,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EInputModificationType _vehicleAcceleration;
        [FieldAttr(nst: 20, ctr: 16)] public EInputModificationType _vehicleBraking;
        [FieldAttr(nst: 24, ctr: 20)] public EInputModificationType _vehicleDrifting;
    }
}
