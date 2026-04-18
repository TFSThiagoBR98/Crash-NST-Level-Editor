namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Lobby_Timer_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Animation_Tag_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Animation_Tag_0x30 = new();
        [FieldAttr(ctr: 56)] public ECGuiLobbyTimerState _Gui_Lobby_Timer_State;
    }
}
