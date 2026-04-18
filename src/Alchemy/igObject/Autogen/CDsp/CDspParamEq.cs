namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CDspParamEq : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _centerFreq = 8000.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _octaveRange = 1.0f;
        [FieldAttr(nst: 56, ctr: 48)] public float _frequencyGain = 1.0f;
        [FieldAttr(nst: 60, ctr: 52)] public float _centerFreqValue;
        [FieldAttr(nst: 64, ctr: 56)] public float _octaveRangeValue;
        [FieldAttr(nst: 68, ctr: 60)] public float _frequencyGainValue;
    }
}
