namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CDspFlangeOverride : CDspOverride
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _dryMix = 0.44999999f;
        [FieldAttr(nst: 36, ctr: 32)] public float _wetMix = 0.55f;
        [FieldAttr(nst: 40, ctr: 36)] public float _depth = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _rate = 0.1f;
    }
}
