namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_ui_backgroundUpdater : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igObject? _InternalStore__timer_0x40 = new();
        [FieldAttr(ctr: 72)] public igObject? _InternalStore_sliderData = new();
        [FieldAttr(ctr: 80)] public igObject? _InternalStore__timer_0x50 = new();
        [FieldAttr(ctr: 88)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 96)] public igHandleMetaField _Material = new();
        [FieldAttr(ctr: 104)] public igObject? _InternalStore__timer_0x68 = new();
        [FieldAttr(ctr: 112)] public igVec4ucMetaField _Color = new();
    }
}
