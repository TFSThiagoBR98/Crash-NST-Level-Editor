namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class PauseMenu_Octane_RestartButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(ctr: 48)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable = new();
    }
}
