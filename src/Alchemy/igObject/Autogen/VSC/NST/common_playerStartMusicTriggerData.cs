namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_playerStartMusicTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _MusicSettings = new();
    }
}
