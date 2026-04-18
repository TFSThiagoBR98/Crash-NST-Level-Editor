namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorOctaneGhostContinueButton : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _buttonPlaceable;
        [FieldAttr(ctr: 24)] public string? _buttonText;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 56)] public igHandleMetaField _buttonIcon = new();
        [FieldAttr(ctr: 64)] public igGuiAnimationCategory? _focusCategory;
    }
}
