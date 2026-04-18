namespace Alchemy
{
    [ObjectAttr(ctr: 544, align: 8)]
    public class CGuiBehaviorOctaneNavigationItem : CGuiBehaviorNavigationItem
    {
        [FieldAttr(ctr: 328, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 336, refCount: false)] public igGuiPlaceable? _icon2Placeable;
        [FieldAttr(ctr: 344)] public igHandleMetaField _iconMaterial = new();
        [FieldAttr(ctr: 352, refCount: false)] public igGuiAnimationTag? _animInit;
        [FieldAttr(ctr: 360, refCount: false)] public igGuiAnimationTag? _animInitLocked;
        [FieldAttr(ctr: 368)] public igVec4ucMetaField _backgroundColor = new();
        [FieldAttr(ctr: 376)] public igHandleMetaField _rightMenuBackground = new();
        [FieldAttr(ctr: 384)] public igHandleMetaField _leftMenuBackground = new();
        [FieldAttr(ctr: 392)] public igHandleMetaField _centralBackground = new();
        [FieldAttr(ctr: 400)] public igHandleMetaField _menuImage = new();
        [FieldAttr(ctr: 408, refCount: false)] public igGuiPlaceable? _menuImagePlaceable;
        [FieldAttr(ctr: 416)] public float _lockedOpacity;
        [FieldAttr(ctr: 424)] public igHandleMetaField _lockIcon = new();
        [FieldAttr(ctr: 432)] public EGuiMenuSound _pressedLockedSound;
        [FieldAttr(ctr: 440)] public string? _hintText;
        [FieldAttr(ctr: 448)] public igVec4ucMetaField _hintTextColor = new();
        [FieldAttr(ctr: 456)] public string? _color;
        [FieldAttr(ctr: 464)] public bool _lockedByStreamingInstall;
        [FieldAttr(ctr: 472, refCount: false)] public igGuiAnimationTag? _showBreadcrumbAnimation;
        [FieldAttr(ctr: 480, refCount: false)] public igGuiAnimationTag? _hideBreadcrumbAnimation;
        [FieldAttr(ctr: 488)] public EOctaneBreadcrumbsCategory _breadcrumbsCategory;
        [FieldAttr(ctr: 496)] public igGuiAnimationCategory? _focusCategory2;
        [FieldAttr(ctr: 504, refCount: false)] public igGuiPlaceable? _itemPlaceable;
        [FieldAttr(ctr: 512)] public bool _inCheatSequence;
        [FieldAttr(ctr: 520)] public igHandleMetaField _iconOverrideMaterial = new();
        [FieldAttr(ctr: 528)] public igHandleMetaField _lockIconOverrideMaterial = new();
        [FieldAttr(ctr: 536)] public bool _skipInitAnim;
    }
}
