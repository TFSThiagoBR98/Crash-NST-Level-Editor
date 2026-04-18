namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CGuiSaveSlotAnimations : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiAnimationTag? _beginAnimation;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAnimationTag? _idleAnimation;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiAnimationTag? _endAnimation;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiAnimationTag? _endAnimationEmpty;
    }
}
