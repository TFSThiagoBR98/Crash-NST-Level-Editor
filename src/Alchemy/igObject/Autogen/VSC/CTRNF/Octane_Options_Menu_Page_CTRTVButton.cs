namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Options_Menu_Page_CTRTVButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 56)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 64)] public bool _Bool;
    }
}
