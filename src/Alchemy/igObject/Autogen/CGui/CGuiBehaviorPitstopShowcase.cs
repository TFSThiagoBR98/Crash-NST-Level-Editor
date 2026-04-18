namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CGuiBehaviorPitstopShowcase : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _singleItemAnim;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _twoItemsBundleAnim;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _threeItemsBundleAnim;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _showContextualMessageAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _hideContextualMessageAnimation;
        [FieldAttr(ctr: 56)] public bool _contextualMessageVisible;
        [FieldAttr(ctr: 64)] public igHandleMetaField _marketplaceSku = new();
        [FieldAttr(ctr: 72, refCount: false)] public igGuiPlaceable? _bundleList;
    }
}
