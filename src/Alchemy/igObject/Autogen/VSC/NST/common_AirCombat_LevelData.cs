namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 4, metaType: typeof(CVscComponentData))]
    public class common_AirCombat_LevelData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 64)] public string? _String = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_Tag_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_0x58 = new();
        [FieldAttr(nst: 96)] public float _Float;
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Fade_In_Preset_Data = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Entity_Tag_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Material_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Material_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Entity_0x90 = new();
    }
}
