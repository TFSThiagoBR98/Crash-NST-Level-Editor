namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class CGameSoundClass : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CGameSoundClassData? _data;
        [FieldAttr(nst: 24, ctr: 24)] public float _cooldownTime;
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _playingSound = new();
        [FieldAttr(nst: 40, ctr: 40)] public bool _lastPlaying;
        [FieldAttr(nst: 41, ctr: 41)] public bool _initialFade;
        [FieldAttr(nst: 42, ctr: 42)] public bool _fadeOut;
        [FieldAttr(nst: 48, ctr: 48)] public CQueuedGameSoundList? _queuedSoundList;
        [FieldAttr(nst: 56, ctr: 56)] public CQueuedGameSoundList? _queuedSoundToRemoveList;
        [FieldAttr(nst: 64, ctr: 64)] public int _failedPlaybacks;
        [FieldAttr(nst: 68, ctr: 68)] public int _interruptedCount;
        [FieldAttr(nst: 72, ctr: 72)] public int _timedOutQueuedSounds;
        [FieldAttr(nst: 76, ctr: 76)] public int _currentQueuedSounds;
        [FieldAttr(nst: 80, ctr: 80)] public int _maxQueuedSounds;
        [FieldAttr(nst: 84, ctr: 84)] public igTimeMetaField _lastFailedTime = new();
        [FieldAttr(nst: 88, ctr: 88)] public igTimeMetaField _lastInterruptTime = new();
    }
}
