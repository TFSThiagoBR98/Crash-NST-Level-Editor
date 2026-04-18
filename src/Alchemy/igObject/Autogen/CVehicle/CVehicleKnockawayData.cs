namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CVehicleKnockawayData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _knockawayForce = 3.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _knockawayDuration = 0.1f;
        [FieldAttr(nst: 24, ctr: 20)] public float _knockawayMaxSpeed = 1000.0f;
    }
}
