namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CGameSoundClassData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _name = null;
        [FieldAttr(nst: 24, ctr: 24)] public EGameSoundClassPlayBehavior _higherPriorityPlayingBehavior;
        [FieldAttr(nst: 28, ctr: 28)] public EGameSoundClassPlayBehavior _samePriorityPlayingBehavior;
        [FieldAttr(nst: 32, ctr: 32)] public EGameSoundClassPlayBehavior _cooldownPlayingBehavior;
        [FieldAttr(nst: 36, ctr: 36)] public int _maxQueue = 2;
        [FieldAttr(nst: 40, ctr: 40)] public float _cooldown;
        [FieldAttr(nst: 44, ctr: 44)] public float _timeout = -1.0f;
        [FieldAttr(nst: 48, ctr: 48)] public float _initialFadeVolume = 0.31f;
        [FieldAttr(nst: 52, ctr: 52)] public float _initialFadeDuration = 0.125f;
        [FieldAttr(nst: 56, ctr: 56)] public float _fadeOutDuration = 0.25f;
        [FieldAttr(nst: 60, ctr: 60)] public bool _hardStopLowerPriorityStreamsOnPlayAttempt;
    }
}
