namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CGuiBehaviorHint : CGuiBehaviorTimedMessage
    {
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igGuiAnimationTag? _scaleTextWidgetAnimation;
        [FieldAttr(nst: 72, ctr: 72)] public igGuiAnimationCategory? _scaleTextWidgetAnimationCategory;
        [FieldAttr(nst: 80, ctr: 80)] public float _maxTextWidth;
    }
}
