namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CKnockawayLandData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _dampeningFactor;
        [FieldAttr(nst: 20, ctr: 16)] public float _standUpSpeedThreshold = 1.25f;
    }
}
