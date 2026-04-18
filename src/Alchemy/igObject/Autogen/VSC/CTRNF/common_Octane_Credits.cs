namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Octane_Credits : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _common_Showroom_Character_CreditsDatas003 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _common_Showroom_Character_CreditsDatas002 = new();
        [FieldAttr(ctr: 56)] public bool _Bool;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Game_Sound_Music_Settings_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Game_Sound_Music_Settings_0x50 = new();
    }
}
