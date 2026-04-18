namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CDspEcho : CDsp
    {
        [FieldAttr(ctr: 40)] public float _delay;
        [FieldAttr(ctr: 44)] public float _decay;
        [FieldAttr(ctr: 48)] public float _maxChannels;
        [FieldAttr(ctr: 52)] public float _dryMix;
        [FieldAttr(ctr: 56)] public float _wetMix;
        [FieldAttr(ctr: 60)] public float _delayValue;
        [FieldAttr(ctr: 64)] public float _decayValue;
        [FieldAttr(ctr: 68)] public float _maxChannelsValue;
        [FieldAttr(ctr: 72)] public float _dryMixValue;
        [FieldAttr(ctr: 76)] public float _wetMixValue;
    }
}
