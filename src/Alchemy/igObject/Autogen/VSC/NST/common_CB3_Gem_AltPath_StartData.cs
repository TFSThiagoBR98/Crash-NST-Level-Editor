namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CB3_Gem_AltPath_StartData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Sound_Music_Settings_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Sound_Music_Settings_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
    }
}
