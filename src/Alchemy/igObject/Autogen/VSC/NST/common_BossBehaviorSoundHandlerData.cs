namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BossBehaviorSoundHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Behavior_State_Group = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(nst: 64)] public bool _Bool;
    }
}
