namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class C1_StartScreen_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Camera_Base_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Camera_Base_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Edc_Info = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Cutscene_Data = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Fade_Sequence_Preset_Data = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 96)] public float _Float;
        [FieldAttr(nst: 104)] public igHandleMetaField _Fade_In_Preset_Data = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity = new();
    }
}
