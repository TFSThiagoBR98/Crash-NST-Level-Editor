namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class H100_Hub_HubAreaDoorManagerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_List_0x28 = new();
        [FieldAttr(ctr: 48)] public bool _Bool_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Edc_Info = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Fade_Sequence_Preset_Data_id_n139ubwj001 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Entity_List_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(ctr: 88)] public bool _Bool_0x58;
        [FieldAttr(ctr: 92)] public EOctaneAdventureCutscene _E_Octane_Adventure_Cutscene;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Entity_Handle_List = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Entity_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Entity_0x78 = new();
    }
}
