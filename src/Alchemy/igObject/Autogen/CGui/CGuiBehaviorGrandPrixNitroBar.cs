namespace Alchemy
{
    [ObjectAttr(ctr: 200, align: 8)]
    public class CGuiBehaviorGrandPrixNitroBar : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _tierNamePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _nitroPointsCounterPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _buttonHelpersPlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _nitroBoostText;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _nitroBoostBackground;
        [FieldAttr(ctr: 56)] public CGuiListItemPopulatorGrandPrixReward? _raceRankingPopulator;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _fillAnim;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _boostedFillAnim;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _barFilledAnim;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _nextTierChangeInAnim;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _nextTierChangeOutAnim;
        [FieldAttr(ctr: 104, refCount: false)] public igGuiAnimationTag? _previousTierChangeInAnim;
        [FieldAttr(ctr: 112, refCount: false)] public igGuiAnimationTag? _previousTierChangeOutAnim;
        [FieldAttr(ctr: 120)] public float _addNitroTime;
        [FieldAttr(ctr: 124)] public float _waitTimeAfterBarUpdateForPopup;
        [FieldAttr(ctr: 128)] public igGuiAnimationCategory? _fillCategory;
        [FieldAttr(ctr: 136)] public igGuiAnimationCategory? _barCategory;
        [FieldAttr(ctr: 144)] public uint _previousAchievementId;
        [FieldAttr(ctr: 148)] public uint _nextAchievementId;
        [FieldAttr(ctr: 152)] public int _previousAchievementCost;
        [FieldAttr(ctr: 156)] public int _nextAchievementCost;
        [FieldAttr(ctr: 160)] public int _currentTierMaxNitroPoints;
        [FieldAttr(ctr: 164)] public int _lastRewardNitroPoints;
        [FieldAttr(ctr: 168)] public int _tierId;
        [FieldAttr(ctr: 172)] public int _initialTierId;
        [FieldAttr(ctr: 176)] public int _nitroPoints;
        [FieldAttr(ctr: 180)] public int _newTierNitroPointsToAdd;
        [FieldAttr(ctr: 184)] public int _completedAchievements;
        [FieldAttr(ctr: 188)] public igTimeMetaField _waitTimeBeforeRewardPopup = new();
        [FieldAttr(ctr: 192)] public bool _canShowReward;
    }
}
