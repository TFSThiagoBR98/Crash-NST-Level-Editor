namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class L127_TheGreatHall_CutsceneOutro_TriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Float_Variable = new();
    }
}
