namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_EndRaceMenu_Restart : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag_0x38 = new();
        [FieldAttr(ctr: 64)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 68)] public bool _Bool;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_Animation_Tag_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Audio_Fade_Data = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Project_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Project_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Gui_Project_0x68 = new();
    }
}
