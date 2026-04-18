namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CDspHighPassSimpleOverride : CDspOverride
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _cutoffFreq = 1000.0f;
    }
}
