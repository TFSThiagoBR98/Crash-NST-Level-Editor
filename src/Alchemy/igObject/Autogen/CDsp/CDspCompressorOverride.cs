namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDspCompressorOverride : CDspOverride
    {
        [FieldAttr(ctr: 28)] public float _threshold;
        [FieldAttr(ctr: 32)] public float _attack;
        [FieldAttr(ctr: 36)] public float _release;
        [FieldAttr(ctr: 40)] public float _makeUpGain;
    }
}
