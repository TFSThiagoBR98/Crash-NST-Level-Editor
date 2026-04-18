namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CDspParamEqParamEqCompressorOverride : CDspOverride
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _centerFreq1 = 8000.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _octaveRange1 = 1.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _frequencyGain1 = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _centerFreq2 = 8000.0f;
        [FieldAttr(nst: 48, ctr: 44)] public float _octaveRange2 = 1.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _frequencyGain2 = 1.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _threshold;
        [FieldAttr(nst: 60, ctr: 56)] public float _attack = 50.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _release = 50.0f;
        [FieldAttr(nst: 68, ctr: 64)] public float _makeUpGain;
    }
}
