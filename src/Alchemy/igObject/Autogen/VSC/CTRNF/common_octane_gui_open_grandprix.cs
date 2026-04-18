namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_octane_gui_open_grandprix : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public igObject? _InternalStore_updateNodeUpdater = new();
        [FieldAttr(ctr: 80)] public string? _String_0x50 = null;
        [FieldAttr(ctr: 88)] public bool _Bool;
    }
}
