namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Crash_ResultScreen_PressToContinue : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public bool _isPressContinueOn;
        [FieldAttr(nst: 48)] public igHandleMetaField _LoadMapFadeOut = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AnimationIdle = new();
        [FieldAttr(nst: 64)] public igGuiInput.ESignal _InputButton;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity = new();
    }
}
