namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 8)]
    public class CGuiBehaviorGameOptionsButton : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiAnimationTag? _pressAnimation;
        [FieldAttr(nst: 152)] public EGuiMenuSound _pressSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 160)] public string? _defaultText = "OPTIONS";
        [FieldAttr(nst: 168, refCount: false)] public igGuiProject? _optionsProject;
    }
}
