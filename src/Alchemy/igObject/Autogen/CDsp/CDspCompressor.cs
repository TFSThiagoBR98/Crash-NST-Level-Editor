namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CDspCompressor : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _threshold;
        [FieldAttr(nst: 52, ctr: 44)] public float _attack = 50.0f;
        [FieldAttr(nst: 56, ctr: 48)] public float _release = 50.0f;
        [FieldAttr(nst: 60, ctr: 52)] public float _makeUpGain;
        [FieldAttr(nst: 64, ctr: 56)] public float _thresholdValue;
        [FieldAttr(nst: 68, ctr: 60)] public float _attackValue;
        [FieldAttr(nst: 72, ctr: 64)] public float _releaseValue;
        [FieldAttr(nst: 76, ctr: 68)] public float _makeUpGainValue;
    }
}
