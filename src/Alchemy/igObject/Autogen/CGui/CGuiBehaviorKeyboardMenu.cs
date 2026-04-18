namespace Alchemy
{
    [ObjectAttr(nst: 208, align: 8)]
    public class CGuiBehaviorKeyboardMenu : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiPlaceable? _textPressKeyPrompt;
        [FieldAttr(nst: 152, refCount: false)] public igGuiList? _optionsList;
        [FieldAttr(nst: 160, refCount: false)] public igGuiAnimationTag? _crash1Animation;
        [FieldAttr(nst: 168, refCount: false)] public igGuiAnimationTag? _crash2Animation;
        [FieldAttr(nst: 176, refCount: false)] public igGuiAnimationTag? _crash3Animation;
        [FieldAttr(nst: 184)] public string? _option1Text = null;
        [FieldAttr(nst: 192)] public string? _option2Text = null;
        [FieldAttr(nst: 200)] public string? _backText = null;
    }
}
