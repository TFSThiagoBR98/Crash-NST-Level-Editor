namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_conditional_respawn_NGin : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _common_conditional_respawnDatas = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _common_conditional_respawnDatas002 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _common_conditional_respawnDatas003 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity = new();
    }
}
