namespace Alchemy
{
    [ObjectAttr(ctr: 200, align: 8)]
    public class CGuiBehaviorBattlePowerUpToggleOption : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiAnimationTag? _animToggleOn;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _animToggleOff;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _animToggleFail;
        [FieldAttr(ctr: 168)] public EGuiMenuSound _toggleSound;
        [FieldAttr(ctr: 172)] public EGuiMenuSound _toggleFailSound;
        [FieldAttr(ctr: 176)] public EPowerUpType _powerUp;
        [FieldAttr(ctr: 184)] public igGuiAnimationCategory? _toggleCategory;
        [FieldAttr(ctr: 192)] public bool _currentValue;
    }
}
