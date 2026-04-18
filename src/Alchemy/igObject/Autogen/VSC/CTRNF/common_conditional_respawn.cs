namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_conditional_respawn : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Player_Start_Entity_Handle_List = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
    }
}
