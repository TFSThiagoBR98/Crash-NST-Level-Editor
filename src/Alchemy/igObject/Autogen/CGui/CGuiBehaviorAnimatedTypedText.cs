namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CGuiBehaviorAnimatedTypedText : igGuiBehavior
    {
        public enum ETypingState
        {
            eTS_Idle = 0,
            eTS_BeginAnimation = 1,
            eTS_Typing = 2,
            eTS_PerCharacterAnimation = 3,
            eTS_EndAnimation = 4,
        }

        [FieldAttr(nst: 16)] public CTimer? _timer;
        [FieldAttr(nst: 24)] public float _secondsPerCharacter;
        [FieldAttr(nst: 28)] public bool _isLooping;
        [FieldAttr(nst: 29)] public bool _clearOnLoad;
        [FieldAttr(nst: 32, refCount: false)] public igGuiAnimationTag? _beginTypeAnimation;
        [FieldAttr(nst: 40, refCount: false)] public igGuiAnimationTag? _endTypeAnimation;
        [FieldAttr(nst: 48, refCount: false)] public igGuiAnimationTag? _perCharacterAnimation;
        [FieldAttr(nst: 56)] public ETypingState _typingState;
        [FieldAttr(nst: 60)] public int _currentIndex;
        [FieldAttr(nst: 64)] public string? _completeText = null;
        [FieldAttr(nst: 72)] public float _leftXCoordinate;
    }
}
