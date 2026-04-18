namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class PauseMenu_2015_Quit_Button : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _HubMapZoneInfo = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _ButtonQuitGameText = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _String_List = new();
        [FieldAttr(nst: 64)] public string? _String = null;
        [FieldAttr(nst: 72)] public int _InternalStore__internalCounter;
        [FieldAttr(nst: 76)] public bool _Bool;
        [FieldAttr(nst: 80)] public igObject? _Player_Variable_Node = new();
        [FieldAttr(nst: 88)] public bool _isLoadBackToHub;
        [FieldAttr(nst: 96)] public igHandleMetaField _TitleScreenZoneInfo = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _LoadMapFadeOut = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _AnimationIdle = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _localCurrZoneInfo = new();
    }
}
