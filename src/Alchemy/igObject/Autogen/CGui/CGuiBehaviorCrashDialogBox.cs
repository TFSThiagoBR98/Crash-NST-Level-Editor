namespace Alchemy
{
    [ObjectAttr(nst: 360, align: 8)]
    public class CGuiBehaviorCrashDialogBox : CGuiBehaviorDialogBox
    {
        [FieldAttr(nst: 280, refCount: false)] public igGuiAnimationTag? _crash1IntroAnimation;
        [FieldAttr(nst: 288, refCount: false)] public igGuiAnimationTag? _crash1IdleAnimation;
        [FieldAttr(nst: 296, refCount: false)] public igGuiAnimationTag? _crash1OutroAnimation;
        [FieldAttr(nst: 304, refCount: false)] public igGuiAnimationTag? _crash2IntroAnimation;
        [FieldAttr(nst: 312, refCount: false)] public igGuiAnimationTag? _crash2IdleAnimation;
        [FieldAttr(nst: 320, refCount: false)] public igGuiAnimationTag? _crash2OutroAnimation;
        [FieldAttr(nst: 328, refCount: false)] public igGuiAnimationTag? _crash3IntroAnimation;
        [FieldAttr(nst: 336, refCount: false)] public igGuiAnimationTag? _crash3IdleAnimation;
        [FieldAttr(nst: 344, refCount: false)] public igGuiAnimationTag? _crash3OutroAnimation;
        [FieldAttr(nst: 352)] public ECrashGame _overrideCrashGame;
    }
}
