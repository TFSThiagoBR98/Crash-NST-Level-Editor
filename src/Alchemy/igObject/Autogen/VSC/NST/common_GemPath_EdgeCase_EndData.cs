namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_GemPath_EdgeCase_EndData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Sound_Music_Settings_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Sound_Music_Settings_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
    }
}
