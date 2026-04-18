namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CMapListsData : igSingleton
    {
        [FieldAttr(ctr: 16)] public CZoneInfoHandleList? _allCtrRaceLevels;
        [FieldAttr(ctr: 24)] public CZoneInfoHandleList? _allCtrArenaLevels;
        [FieldAttr(ctr: 32)] public CZoneInfoHandleList? _allCnkRaceLevels;
        [FieldAttr(ctr: 40)] public CZoneInfoHandleList? _allCnkArenaLevels;
    }
}
