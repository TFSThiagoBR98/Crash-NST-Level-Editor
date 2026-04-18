namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class H100_Hub_SaveScreenData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
    }
}
