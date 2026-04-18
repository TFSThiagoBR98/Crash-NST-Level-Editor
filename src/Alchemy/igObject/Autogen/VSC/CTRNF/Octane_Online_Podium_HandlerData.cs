namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class Octane_Online_Podium_HandlerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Fade_In_Preset_Data_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Bolt_Point_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Fade_In_Preset_Data_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Game_Bool_Variable = new();
    }
}
