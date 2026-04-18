namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 192, align: 8)]
    public class CGuiBehaviorTimer : igGuiBehavior
    {
        [FieldAttr(nst: 16)] public CGuiTimerData? _timerData;
        [FieldAttr(ctr: 16)] public igHandleMetaField _entity = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _boltPoint = new();
        [FieldAttr(ctr: 32)] public CTimer? _timer;
        [FieldAttr(ctr: 40)] public float _timerDuration;
        [FieldAttr(nst: 24, ctr: 48)] public CGuiScriptTimerData? _scriptTimerData;
        [FieldAttr(nst: 32, ctr: 56)] public bool _sentCloseEvent;
        [FieldAttr(nst: 33, ctr: 57)] public bool _startedLowTimeAnimation;
        [FieldAttr(nst: 34, ctr: 58)] public bool _isClosing;
        [FieldAttr(nst: 35, ctr: 59)] public bool _switchedToUrgentSound;
        [FieldAttr(nst: 40, ctr: 64)] public igHandleMetaField _playingSound = new();
        [FieldAttr(nst: 48, ctr: 72)] public float _lowTimeAnimationStartTime = 10.0f;
        [FieldAttr(nst: 56, ctr: 80, refCount: false)] public igGuiPlaceable? _timeRemainingText;
        [FieldAttr(nst: 64, ctr: 88, refCount: false)] public igGuiAnimationTag? _addTimeAnimation;
        [FieldAttr(nst: 72, ctr: 96)] public igGuiAnimationCategory? _addTimeAnimationCategory;
        [FieldAttr(nst: 80, ctr: 104, refCount: false)] public igGuiAnimationTag? _lowTimeAnimation;
        [FieldAttr(nst: 88, ctr: 112)] public igGuiAnimationCategory? _lowTimeAnimationCategory;
        [FieldAttr(nst: 96, ctr: 120, refCount: false)] public igGuiPlaceable? _fadeOutPlaceable;
        [FieldAttr(nst: 104, ctr: 128, refCount: false)] public igGuiAnimationTag? _fadeOutAnimation;
        [FieldAttr(nst: 112, ctr: 136)] public igGuiAnimationCategory? _fadeOutAnimationCategory;
        [FieldAttr(nst: 120, ctr: 144, refCount: false)] public igGuiPlaceable? _starPlaceable;
        [FieldAttr(nst: 128, ctr: 152)] public igHandleMetaField _loopingTickSound = new();
        [FieldAttr(nst: 136, ctr: 160)] public bool _loopingTickSoundFadeOut;
        [FieldAttr(nst: 144, ctr: 168)] public igHandleMetaField _loopingUrgentTickSound = new();
        [FieldAttr(nst: 152, ctr: 176)] public bool _loopingUrgentTickSoundFadeOut;
        [FieldAttr(nst: 156, ctr: 180)] public float _urgentSoundTimeRemainingPercentage = 30.0f;
        [FieldAttr(ctr: 184)] public float _wantedDuration;
    }
}
