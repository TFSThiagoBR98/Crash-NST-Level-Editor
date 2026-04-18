namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_Old_Boost_Bar_Positioning : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EOctaneBoostBarType _E_Octane_Boost_Bar_Type;
        [FieldAttr(ctr: 48)] public igObject? _InternalStore_counter = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Placeable_0x40 = new();
    }
}
