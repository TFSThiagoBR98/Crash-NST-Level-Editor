namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Crash_Pause_Quit_Button : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public int _InternalStore__internalCounter;
        [FieldAttr(nst: 48)] public igHandleMetaField _TitleScreenZoneInfo = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _LoadMapFadeOut = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _localCurrZoneInfo = new();
        [FieldAttr(nst: 72)] public bool _isLoadBackToHub;
        [FieldAttr(nst: 80)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 88)] public igObject? _Player_Variable_Node = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Zone_Info_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Zone_Info_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Sound = new();
    }
}
