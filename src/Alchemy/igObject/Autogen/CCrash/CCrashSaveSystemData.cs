namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CCrashSaveSystemData : CSaveSystemData
    {
        [FieldAttr(nst: 32)] public int _saveSlotsPerGame = 4;
        [FieldAttr(nst: 40)] public string? _mostRecentSaveSlotKeyCrash1 = "most_recent_save_slot_crash1";
        [FieldAttr(nst: 48)] public string? _mostRecentSaveSlotKeyCrash2 = "most_recent_save_slot_crash2";
        [FieldAttr(nst: 56)] public string? _mostRecentSaveSlotKeyCrash3 = "most_recent_save_slot_crash3";
    }
}
