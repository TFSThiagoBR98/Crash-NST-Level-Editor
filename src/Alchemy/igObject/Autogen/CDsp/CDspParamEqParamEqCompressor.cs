namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class CDspParamEqParamEqCompressor : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _centerFreq1 = 8000.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _octaveRange1 = 1.0f;
        [FieldAttr(nst: 56, ctr: 48)] public float _frequencyGain1 = 1.0f;
        [FieldAttr(nst: 60, ctr: 52)] public float _centerFreq2 = 8000.0f;
        [FieldAttr(nst: 64, ctr: 56)] public float _octaveRange2 = 1.0f;
        [FieldAttr(nst: 68, ctr: 60)] public float _frequencyGain2 = 1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _threshold;
        [FieldAttr(nst: 76, ctr: 68)] public float _attack = 50.0f;
        [FieldAttr(nst: 80, ctr: 72)] public float _release = 50.0f;
        [FieldAttr(nst: 84, ctr: 76)] public float _makeUpGain;
        [FieldAttr(nst: 88, ctr: 80)] public float _centerFreq1Value;
        [FieldAttr(nst: 92, ctr: 84)] public float _octaveRange1Value;
        [FieldAttr(nst: 96, ctr: 88)] public float _frequencyGain1Value;
        [FieldAttr(nst: 100, ctr: 92)] public float _centerFreq2Value;
        [FieldAttr(nst: 104, ctr: 96)] public float _octaveRange2Value;
        [FieldAttr(nst: 108, ctr: 100)] public float _frequencyGain2Value;
        [FieldAttr(nst: 112, ctr: 104)] public float _thresholdValue;
        [FieldAttr(nst: 116, ctr: 108)] public float _attackValue;
        [FieldAttr(nst: 120, ctr: 112)] public float _releaseValue;
        [FieldAttr(nst: 124, ctr: 116)] public float _makeUpGainValue;
    }
}
