namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_gatedMusicTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _StartDisabled;
        [FieldAttr(nst: 48)] public igHandleMetaField _OtherBox = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _MusicSettings = new();
    }
}
