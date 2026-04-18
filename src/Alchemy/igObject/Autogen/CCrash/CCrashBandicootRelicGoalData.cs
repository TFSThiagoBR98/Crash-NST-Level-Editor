namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CCrashBandicootRelicGoalData : CAccoladeGoalData
    {
        [FieldAttr(nst: 32)] public int _sapphireOrBetterRelics;
        [FieldAttr(nst: 36)] public int _goldOrBetterRelics;
        [FieldAttr(nst: 40)] public int _platinumOrBetterRelics;
    }
}
