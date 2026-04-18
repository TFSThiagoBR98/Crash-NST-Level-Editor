namespace Alchemy
{
    [ObjectAttr(ctr: 504, align: 8)]
    public class CGuiBehaviorBattleTypeSettingSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448, refCount: false)] public igGuiAnimationTag? _showLimitBattle;
        [FieldAttr(ctr: 456, refCount: false)] public igGuiAnimationTag? _showCaptureTheFlag;
        [FieldAttr(ctr: 464, refCount: false)] public igGuiAnimationTag? _showCrystalGrab;
        [FieldAttr(ctr: 472, refCount: false)] public igGuiAnimationTag? _showLastKartDriving;
        [FieldAttr(ctr: 480, refCount: false)] public igGuiAnimationTag? _showStealTheBacon;
        [FieldAttr(ctr: 488, refCount: false)] public igGuiAnimationTag? _showSingleRace;
        [FieldAttr(ctr: 496)] public igGuiAnimationCategory? _showTypeCategory;
    }
}
