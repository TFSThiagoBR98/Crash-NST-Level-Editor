namespace Alchemy
{
    [ObjectAttr(ctr: 216, align: 8)]
    public class CGuiBehaviorPitstopShowcaseBundleListItem : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _statusIconPlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiPlaceable? _focusedBackgroundPlaceable;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiPlaceable? _unfocusedBackgroundPlaceable;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiPlaceable? _nitroBoostIcon;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiPlaceable? _nitroBoostText;
        [FieldAttr(ctr: 200)] public float _previewDelaySeconds;
        [FieldAttr(ctr: 204)] public igTimeMetaField _previewTime = new();
        [FieldAttr(ctr: 208)] public igHandleMetaField _listItem = new();
    }
}
