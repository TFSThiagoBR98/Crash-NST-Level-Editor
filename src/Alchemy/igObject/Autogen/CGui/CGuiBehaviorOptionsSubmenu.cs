namespace Alchemy
{
    [ObjectAttr(nst: 248, align: 8)]
    public class CGuiBehaviorOptionsSubmenu : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiPlaceable? _textGamepadControls;
        [FieldAttr(nst: 152, refCount: false)] public igGuiPlaceable? _textKeyboardControls;
        [FieldAttr(nst: 160, refCount: false)] public igGuiPlaceable? _textGraphics;
        [FieldAttr(nst: 168)] public string? _backText = null;
        [FieldAttr(nst: 176, refCount: false)] public igGuiProject? _gamepadControlsProject;
        [FieldAttr(nst: 184, refCount: false)] public igGuiProject? _keyboardControlsProject;
        [FieldAttr(nst: 192, refCount: false)] public igGuiProject? _graphicsProject;
        [FieldAttr(nst: 200)] public float _delayInputDuration;
        [FieldAttr(nst: 208, refCount: false)] public igGuiAnimationTag? _crash1Animation;
        [FieldAttr(nst: 216, refCount: false)] public igGuiAnimationTag? _crash2Animation;
        [FieldAttr(nst: 224, refCount: false)] public igGuiAnimationTag? _crash3Animation;
        [FieldAttr(nst: 232, refCount: false)] public igGuiAnimationTag? _menuIntroAnimation;
        [FieldAttr(nst: 240, refCount: false)] public igGuiAnimationTag? _menuOutroAnimation;
    }
}
