namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_MainMenu_RaceModeSettings_Movie : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public float _Float;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 64)] public igObject? _InternalStore_sliderData = new();
        [FieldAttr(ctr: 72)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 76)] public bool _Bool;
    }
}
