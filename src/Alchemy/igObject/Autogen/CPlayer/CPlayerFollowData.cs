namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CPlayerFollowData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _followRatio = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _maxAngle = 10.0f;
    }
}
