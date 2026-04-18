namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CBaseVehicleSettingList : igObjectList<CBaseVehicleSetting>
    {
        [FieldAttr(nst: 40, ctr: 40)] public EVehicleStat _statType;
    }
}
