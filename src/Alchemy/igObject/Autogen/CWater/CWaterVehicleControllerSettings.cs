namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class CWaterVehicleControllerSettings : CBaseVehicleControllerSettings
    {
        [FieldAttr(nst: 112, ctr: 112)] public CBuoyancyVehicleSettingList? _buoyancyStat;
    }
}
