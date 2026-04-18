namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_EndRaceTimer : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igObject? _InternalStore_updateNodeUpdater = new();
        [FieldAttr(ctr: 48)] public string? _String = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Gui_Placeable_0x50 = new();
    }
}
