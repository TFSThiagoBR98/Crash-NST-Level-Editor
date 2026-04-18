namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CAmbientAudioComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _sound = new();
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _dopplerData = new();
        [FieldAttr(nst: 40, ctr: 32)] public float _minRepeatDelay = 5.0f;
        [FieldAttr(nst: 44, ctr: 36)] public float _maxRepeatDelay = 10.0f;
        [FieldAttr(nst: 48, ctr: 40)] public bool _soundPlayingMatchesHiddenState;
        [FieldAttr(nst: 49, ctr: 41)] public bool _startActive = true;
    }
}
