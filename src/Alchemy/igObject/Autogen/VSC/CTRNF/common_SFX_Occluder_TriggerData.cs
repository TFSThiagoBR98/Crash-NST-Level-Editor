namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class common_SFX_Occluder_TriggerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity_List = new();
    }
}
