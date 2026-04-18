namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class CLandVehicleControllerSettings : CBaseVehicleControllerSettings
    {
        [FieldAttr(nst: 112, ctr: 112)] public CTractionVehicleSettingList? _tractionStat;
    }
}
