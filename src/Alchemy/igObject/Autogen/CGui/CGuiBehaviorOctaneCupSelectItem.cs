namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 8)]
    public class CGuiBehaviorOctaneCupSelectItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _cupButton;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 48)] public string? _levelToLoad;
        [FieldAttr(ctr: 56)] public igHandleMetaField _cupIcon = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _cupImage1 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _cupImage2 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _cupImage3 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _cupImage4 = new();
        [FieldAttr(ctr: 96)] public string? _cupName;
        [FieldAttr(ctr: 104)] public string? _cupDescription;
        [FieldAttr(ctr: 112)] public igHandleMetaField _cupData = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _minimapImage = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _backgroundImage = new();
        [FieldAttr(ctr: 136)] public igVec4ucMetaField _cupColor = new();
        [FieldAttr(ctr: 144)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 152)] public igHandleMetaField _cupAmbienceSFX = new();
    }
}
