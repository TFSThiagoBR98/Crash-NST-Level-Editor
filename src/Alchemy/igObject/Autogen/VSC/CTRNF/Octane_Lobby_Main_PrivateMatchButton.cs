namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Lobby_Main_PrivateMatchButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Game_Int_Variable = new();
    }
}
