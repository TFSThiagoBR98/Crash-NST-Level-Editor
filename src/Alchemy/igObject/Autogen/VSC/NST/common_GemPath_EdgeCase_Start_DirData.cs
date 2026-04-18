namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_GemPath_EdgeCase_Start_DirData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Sound_Music_Settings_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Sound_Music_Settings_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Sound_Music_Settings_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
    }
}
