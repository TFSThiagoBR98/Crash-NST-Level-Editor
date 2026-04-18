namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CGuiBehaviorPitstopNitroFillUpButton : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _priceText;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _statusIcon;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _unlockText;
        [FieldAttr(ctr: 40)] public string? _initialText;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _showStatusAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _inactiveAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _pressAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _pressInactiveAnimation;
        [FieldAttr(ctr: 80)] public uint _fillUpPrice;
        [FieldAttr(ctr: 84)] public int _missingNitro;
        [FieldAttr(ctr: 88)] public igHandleMetaField _purchaseConfirmedFunction = new();
        [FieldAttr(ctr: 96)] public bool _purchaseTaskActive;
        [FieldAttr(ctr: 97)] public bool _recievedFillUp;
        [FieldAttr(ctr: 100)] public float _confirmPurchasedMenuLockTime;
    }
}
