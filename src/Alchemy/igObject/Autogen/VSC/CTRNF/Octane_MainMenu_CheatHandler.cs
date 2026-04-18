namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_MainMenu_CheatHandler : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EOctaneCheats _E_Octane_Cheats;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _InternalStore_project_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _InternalStore_project_0x50 = new();
        [FieldAttr(ctr: 88)] public bool _Bool;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Localized_String_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Localized_String_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 128)] public string? _String = null;
    }
}
