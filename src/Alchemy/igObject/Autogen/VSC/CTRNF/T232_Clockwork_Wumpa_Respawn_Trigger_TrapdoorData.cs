namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class T232_Clockwork_Wumpa_Respawn_Trigger_TrapdoorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Player_Start_Entity_Handle_List = new();
    }
}
