namespace Alchemy
{
    [ObjectAttr(ctr: 392, align: 8)]
    public class CGuiBehaviorOctaneStoreItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _emptyAnimation;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _discountAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _focusedVFX;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _emptyPressedAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _characterBundleIdleAnim;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _kartSetIdleAnim;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _characterIdleAnim;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _skinIdleAnim;
        [FieldAttr(ctr: 104, refCount: false)] public igGuiAnimationTag? _paintjobIdleAnim;
        [FieldAttr(ctr: 112, refCount: false)] public igGuiAnimationTag? _decalIdleAnim;
        [FieldAttr(ctr: 120, refCount: false)] public igGuiAnimationTag? _wheelsIdleAnim;
        [FieldAttr(ctr: 128, refCount: false)] public igGuiAnimationTag? _stickersIdleAnim;
        [FieldAttr(ctr: 136, refCount: false)] public igGuiAnimationTag? _noBackgroundAnimation;
        [FieldAttr(ctr: 144, refCount: false)] public igGuiAnimationTag? _basicAnimation;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _exoticAnimation;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _legendaryAnimation;
        [FieldAttr(ctr: 168)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 176)] public igGuiAnimationCategory? _rarityCategory;
        [FieldAttr(ctr: 184)] public igGuiAnimationCategory? _idleCategory;
        [FieldAttr(ctr: 192)] public igGuiAnimationCategory? _discountCategory;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiPlaceable? _nameText;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiPlaceable? _soldOutText;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiPlaceable? _discountPriceText;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiPlaceable? _fullPriceText;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiPlaceable? _priceBG;
        [FieldAttr(ctr: 240, refCount: false)] public igGuiPlaceable? _imagePlace;
        [FieldAttr(ctr: 248, refCount: false)] public igGuiPlaceable? _categoryBG;
        [FieldAttr(ctr: 256, refCount: false)] public igGuiPlaceable? _loadingIcon;
        [FieldAttr(ctr: 264, refCount: false)] public igGuiPlaceable? _categoryText;
        [FieldAttr(ctr: 272)] public igHandleMetaField _characterBundleBGImage = new();
        [FieldAttr(ctr: 280)] public igHandleMetaField _kartSetBGImage = new();
        [FieldAttr(ctr: 288)] public igHandleMetaField _characterBGImage = new();
        [FieldAttr(ctr: 296)] public igHandleMetaField _skinBGImage = new();
        [FieldAttr(ctr: 304)] public igHandleMetaField _paintjobBGImage = new();
        [FieldAttr(ctr: 312)] public igHandleMetaField _decalBGImage = new();
        [FieldAttr(ctr: 320)] public igHandleMetaField _wheelsBGImage = new();
        [FieldAttr(ctr: 328)] public igHandleMetaField _stickersBGImage = new();
        [FieldAttr(ctr: 336, refCount: false)] public igGuiPlaceable? _nitroBoostIcon;
        [FieldAttr(ctr: 344, refCount: false)] public igGuiPlaceable? _nitroBoostText;
        [FieldAttr(ctr: 352, refCount: false)] public igGuiPlaceable? _discountTag;
        [FieldAttr(ctr: 360, refCount: false)] public igGuiPlaceable? _discountText;
        [FieldAttr(ctr: 368, refCount: false)] public igGuiPlaceable? _limitedTimeTag;
        [FieldAttr(ctr: 376)] public igHandleMetaField _marketplaceSku = new();
        [FieldAttr(ctr: 384)] public int _locationIndex;
    }
}
