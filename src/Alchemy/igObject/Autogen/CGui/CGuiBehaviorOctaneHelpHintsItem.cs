namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CGuiBehaviorOctaneHelpHintsItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _hintButton;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 48)] public string? _hintName;
        [FieldAttr(ctr: 56)] public bool _hintLocked;
        [FieldAttr(ctr: 64)] public string? _hintMovieName;
        [FieldAttr(ctr: 72)] public igHandleMetaField _hintImage = new();
        [FieldAttr(ctr: 80)] public string? _hintText;
        [FieldAttr(ctr: 88)] public string? _hintVoiceOverName;
        [FieldAttr(ctr: 96)] public igGuiAnimationCategory? _focusCategory;
    }
}
