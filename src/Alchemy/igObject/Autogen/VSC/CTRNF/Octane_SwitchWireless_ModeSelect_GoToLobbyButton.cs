namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_SwitchWireless_ModeSelect_GoToLobbyButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public int _Int;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 56)] public EAsyncMatchmakingGameTypes _E_Async_Matchmaking_Game_Types;
    }
}
