namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CCrashBandicootKeyGoalData : CAccoladeGoalData
    {
        [FieldAttr(nst: 32)] public CZoneInfoHandleList? _levels;
    }
}
