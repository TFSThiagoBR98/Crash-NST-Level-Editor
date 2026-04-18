namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_SwitchWireless_Lobby_SettingsButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable = new();
    }
}
