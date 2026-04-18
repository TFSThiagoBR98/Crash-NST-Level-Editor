namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T155_Sony_Stadium_SFX_Crowd_Cheer_TriggerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
    }
}
