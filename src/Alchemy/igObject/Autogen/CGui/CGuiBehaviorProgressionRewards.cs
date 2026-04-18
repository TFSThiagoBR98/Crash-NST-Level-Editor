namespace Alchemy
{
    [ObjectAttr(ctr: 240, align: 8)]
    public class CGuiBehaviorProgressionRewards : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTagList? _layoutAnimations;
        [FieldAttr(ctr: 24)] public igNonRefCountedGuiPlaceableList? _rewardIconPlaceables;
        [FieldAttr(ctr: 32)] public igNonRefCountedGuiPlaceableList? _rewardTextPlaceables;
        [FieldAttr(ctr: 40)] public igNonRefCountedGuiPlaceableList? _rewardDescriptionPlaceables;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _additionalInfoTextPlaceable;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _popupAnimIn;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _popupAnimOut;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _rewardAnimIn;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _rewardAnimOut;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _rewardAnimLoop;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _additionalInfoAnim;
        [FieldAttr(ctr: 104)] public int _currentRewardIndex;
        [FieldAttr(ctr: 112)] public CProgressionChallenge? _completedChallenge;
        [FieldAttr(ctr: 120)] public igGuiAnimationCategory? _animCategory;
        [FieldAttr(ctr: 128)] public bool _closeUi;
        [FieldAttr(ctr: 136)] public string? _driverRewardDescription;
        [FieldAttr(ctr: 144)] public string? _kartRewardDescription;
        [FieldAttr(ctr: 152)] public string? _skinRewardDescription;
        [FieldAttr(ctr: 160)] public string? _coinRewardDescription;
        [FieldAttr(ctr: 168)] public string? _wheelRewardDescription;
        [FieldAttr(ctr: 176)] public string? _colorRewardDescription;
        [FieldAttr(ctr: 184)] public string? _decalRewardDescription;
        [FieldAttr(ctr: 192)] public string? _stickerRewardDescription;
        [FieldAttr(ctr: 200)] public string? _trackRewardDescription;
        [FieldAttr(ctr: 208)] public string? _defaultRewardDescription;
        [FieldAttr(ctr: 216)] public int _rewardCount;
        [FieldAttr(ctr: 224)] public CChangeRequest? _lockControls;
        [FieldAttr(ctr: 232)] public CMarketplaceItemHandleList? _marketplaceRewards;
    }
}
