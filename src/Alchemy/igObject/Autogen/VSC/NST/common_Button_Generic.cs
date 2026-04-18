namespace Alchemy
{
    [ObjectAttr(nst: 184, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Button_Generic : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public bool _Focused_On_Start;
        [FieldAttr(nst: 44)] public EGuiMenuSound _NavigationSound;
        [FieldAttr(nst: 48)] public igHandleMetaField _FocusAnimationCategory = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AnimationPress = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _AnimationLoseFocus = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _AnimationGainFocus = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _ButtonSpritePlaceable = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _GuiPlaceableVariable_id_30pylgup_variable = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _ButtonTextPlaceable = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _ButtonToTheDown = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _ButtonToTheUp = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _ButtonToTheRight = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _ButtonToTheLeft = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Button_Material = new();
        [FieldAttr(nst: 144)] public igObject? _Internal_TimerAction_id_amfz1mz4_timer = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Button_Text = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _InputMaterial = new();
        [FieldAttr(nst: 168)] public bool _InputFocus;
        [FieldAttr(nst: 176)] public igObject? _Localized_String = new();
    }
}
