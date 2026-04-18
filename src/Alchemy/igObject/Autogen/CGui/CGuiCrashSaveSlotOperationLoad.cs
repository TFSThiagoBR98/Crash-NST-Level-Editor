namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 8)]
    public class CGuiCrashSaveSlotOperationLoad : CGuiSaveSlotOperationLoad
    {
        [FieldAttr(nst: 128)] public igHandleMetaField _crash1OnLoadedLevel = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _crash2OnLoadedLevel = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _crash3OnLoadedLevel = new();
    }
}
