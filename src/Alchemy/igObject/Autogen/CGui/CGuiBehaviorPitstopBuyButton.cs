namespace Alchemy
{
    [ObjectAttr(ctr: 232, align: 8)]
    public class CGuiBehaviorPitstopBuyButton : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _pricePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _discountedPricePlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _imageIconPlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _loadingIcon;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _contourPlaceable;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _initializationAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _discountedPriceAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _showStatusAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _purchasedStatusAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _pressedFailedAnimation;
        [FieldAttr(ctr: 104, refCount: false)] public igGuiAnimationTag? _unavailableAnim;
        [FieldAttr(ctr: 112, refCount: false)] public igGuiAnimationTag? _notEnoughCoinsAnim;
        [FieldAttr(ctr: 120, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 128, refCount: false)] public igGuiPlaceable? _focusedBackgroundPlaceable;
        [FieldAttr(ctr: 136, refCount: false)] public igGuiPlaceable? _statusIcon;
        [FieldAttr(ctr: 144)] public CGuiCustomizationGridData? _data;
        [FieldAttr(ctr: 152)] public CKartCustomizationPreset? _kartPreset;
        [FieldAttr(ctr: 160)] public igHandleMetaField _delayPreviewFunction = new();
        [FieldAttr(ctr: 168)] public igHandleMetaField _purchaseConfirmedFunction = new();
        [FieldAttr(ctr: 176)] public float _previewDelaySeconds;
        [FieldAttr(ctr: 180)] public float _confirmPurchasedMenuLockTime;
        [FieldAttr(ctr: 184)] public CMarketplaceSku? _marketplaceSku;
        [FieldAttr(ctr: 192)] public string? _buyString;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiPlaceable? _buyStringPlaceable;
        [FieldAttr(ctr: 208)] public bool _statusIconVisible;
        [FieldAttr(ctr: 209)] public bool _purchaseTaskActive;
        [FieldAttr(ctr: 216)] public igHandleMetaField _unlockSound = new();
        [FieldAttr(ctr: 224)] public EBuyButtonStatusIconState _state;
    }
}
