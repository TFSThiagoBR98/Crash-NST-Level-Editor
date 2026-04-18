namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Lobby_PrivateGame_CustomizationButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public bool _Bool;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity = new();
    }
}
