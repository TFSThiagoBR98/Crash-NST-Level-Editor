namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CDspFlange : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _dryMix = 0.44999999f;
        [FieldAttr(nst: 52, ctr: 44)] public float _wetMix = 0.55f;
        [FieldAttr(nst: 56, ctr: 48)] public float _depth = 1.0f;
        [FieldAttr(nst: 60, ctr: 52)] public float _rate = 0.1f;
        [FieldAttr(nst: 64, ctr: 56)] public float _dryMixValue;
        [FieldAttr(nst: 68, ctr: 60)] public float _wetMixValue;
        [FieldAttr(nst: 72, ctr: 64)] public float _depthValue;
        [FieldAttr(nst: 76, ctr: 68)] public float _rateValue;
    }
}
