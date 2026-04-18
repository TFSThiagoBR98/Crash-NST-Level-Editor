namespace Alchemy
{
    [ObjectAttr(nst: 280, ctr: 296, align: 8)]
    public class CGuiBehaviorDialogBox : CGuiBehaviorDialogBoxOption
    {
        [FieldAttr(nst: 176, ctr: 168, refCount: false)] public igGuiPlaceable? _option1placeable;
        [FieldAttr(nst: 184, ctr: 176, refCount: false)] public igGuiPlaceable? _option2placeable;
        [FieldAttr(nst: 192, ctr: 184, refCount: false)] public igGuiPlaceable? _bodyText;
        [FieldAttr(nst: 200, ctr: 192, refCount: false)] public igGuiPlaceable? _titleText;
        [FieldAttr(nst: 208, ctr: 200, refCount: false)] public igGuiPlaceable? _imagePlaceable;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(nst: 216, ctr: 216, refCount: false)] public igGuiAnimationTag? _introAnimation;
        [FieldAttr(nst: 224, ctr: 224, refCount: false)] public igGuiAnimationTag? _outroAnimation;
        [FieldAttr(nst: 232, ctr: 232, refCount: false)] public igGuiAnimationTag? _idleAnimation;
        [FieldAttr(nst: 240, ctr: 240, refCount: false)] public igGuiAnimationTag? _noButtonSetupAnimation;
        [FieldAttr(nst: 248, ctr: 248)] public EigGuiAnimationLoopMode _animIdleLoopMode = EigGuiAnimationLoopMode.kGuiLoopRepeat;
        [FieldAttr(nst: 256, ctr: 256)] public CChangeRequestList? _changeRequests;
        [FieldAttr(nst: 264, ctr: 264)] public CScopedScheduledFunction? _delayInputFunction;
        [FieldAttr(ctr: 272)] public string? _cancelButtonLegendText;
        [FieldAttr(ctr: 280)] public EButtonLegendButton _defaultCancelInput;
        [FieldAttr(ctr: 284)] public EButtonLegendButton _noOptionContinueInput;
        [FieldAttr(nst: 272, ctr: 288)] public igGuiAnimationCategory? _animationCategory;
    }
}
