namespace Alchemy
{
    [ObjectAttr(ctr: 504, align: 8)]
    public class CGuiBehaviorWinningConditionSettingSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448)] public string? _pointsText;
        [FieldAttr(ctr: 456)] public string? _timeText;
        [FieldAttr(ctr: 464)] public string? _livesText;
        [FieldAttr(ctr: 472, refCount: false)] public igGuiAnimationTag? _showPoints;
        [FieldAttr(ctr: 480, refCount: false)] public igGuiAnimationTag? _showTime;
        [FieldAttr(ctr: 488, refCount: false)] public igGuiAnimationTag? _showLives;
        [FieldAttr(ctr: 496)] public igGuiAnimationCategory? _showConditionCategory;
    }
}
