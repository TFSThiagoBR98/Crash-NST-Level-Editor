namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Octane_OnlineLobby_StartMenuData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Game_Sound_Music_Settings_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Game_Sound_Music_Settings_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Game_Sound_Music_Settings_0x38 = new();
    }
}
