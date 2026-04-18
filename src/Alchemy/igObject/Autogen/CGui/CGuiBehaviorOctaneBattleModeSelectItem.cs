namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CGuiBehaviorOctaneBattleModeSelectItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _battleModeButton;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 48)] public EOctaneRaceModes _battleMode;
        [FieldAttr(ctr: 56)] public igHandleMetaField _battleModeIcon = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _battleModeImage = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _battleModeRightBackground = new();
        [FieldAttr(ctr: 80)] public igGuiAnimationCategory? _focusCategory;
    }
}
