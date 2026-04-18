namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CGuiOctaneSaveSlotOperationLoad : CGuiSaveSlotOperationLoad
    {
        [FieldAttr(ctr: 152)] public igHandleMetaField _Octane1OnLoadedLevel = new();
        [FieldAttr(ctr: 160)] public igHandleMetaField _Octane2OnLoadedLevel = new();
        [FieldAttr(ctr: 168)] public igHandleMetaField _Octane3OnLoadedLevel = new();
    }
}
