namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CSoundUpdateVelocityBased : CSoundUpdateMethod
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _minVelocity;
        [FieldAttr(nst: 52, ctr: 44)] public float _maxVelocity = 100.0f;
    }
}
