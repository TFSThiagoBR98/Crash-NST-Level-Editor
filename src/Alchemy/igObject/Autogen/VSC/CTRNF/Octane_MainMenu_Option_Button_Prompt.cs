namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_MainMenu_Option_Button_Prompt : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public bool _Bool;
        [FieldAttr(ctr: 72)] public string? _String = null;
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Animation_Tag_0x50 = new();
        [FieldAttr(ctr: 88)] public EOctaneRaceModes _E_Octane_Race_Modes_0x58;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Gui_Animation_Tag_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Gui_Animation_Tag_0x70 = new();
        [FieldAttr(ctr: 120)] public EOctaneRaceModes _E_Octane_Race_Modes_0x78;
    }
}
