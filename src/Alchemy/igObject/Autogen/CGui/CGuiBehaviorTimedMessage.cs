namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CGuiBehaviorTimedMessage : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16)] public CTimer? _timer;
        [FieldAttr(nst: 24, ctr: 24)] public float _secondsActive;
        [FieldAttr(nst: 28, ctr: 28)] public float _secondsAfterQueue = 1.0f;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiAnimationTag? _introAnimation;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiAnimationTag? _outroAnimation;
        [FieldAttr(nst: 56, ctr: 56)] public ETimerType _durationType;
    }
}
