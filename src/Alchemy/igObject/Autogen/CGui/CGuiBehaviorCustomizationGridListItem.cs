namespace Alchemy
{
    [ObjectAttr(ctr: 240, align: 8)]
    public class CGuiBehaviorCustomizationGridListItem : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _focusedBackgroundPlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiPlaceable? _lockIconPlaceable;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiPlaceable? _nitroBonusIcon;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiPlaceable? _nitroBonusText;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiAnimationTag? _showBreadcrumbAnimation;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiAnimationTag? _breadcrumbsIdleAnimation;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiAnimationTag? _hideBreadcrumbAnimation;
        [FieldAttr(ctr: 216)] public float _previewDelaySeconds;
        [FieldAttr(ctr: 224)] public igHandleMetaField _listItem = new();
        [FieldAttr(ctr: 232)] public igTimeMetaField _previewTime = new();
        [FieldAttr(ctr: 236)] public bool _breadcrumbVisible;
    }
}
