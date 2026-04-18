namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CSaveSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _allowSavingCheckpoints = true;
        [FieldAttr(nst: 20, ctr: 16)] public int _autoSaveSlot;
        [FieldAttr(nst: 24, ctr: 24)] public string? _mostRecentSaveSlotKey = "most_recent_save_slot";
    }
}
