namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CDspLowPassSimple : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _cutoffFreq = 5000.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _cutoffFreqValue;
    }
}
