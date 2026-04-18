namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CDspDistortion : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _level = 0.5f;
        [FieldAttr(nst: 52, ctr: 44)] public float _levelValue;
    }
}
