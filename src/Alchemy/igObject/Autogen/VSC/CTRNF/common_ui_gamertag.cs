namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_ui_gamertag : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public string? _String = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(ctr: 64)] public igObject? _InternalStore_updateNodeUpdater = new();
    }
}
