namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CKnockawayFlightData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _transitionAltitude;
        [FieldAttr(nst: 20, ctr: 16)] public float _recoveryAltitude;
        [FieldAttr(nst: 24, ctr: 20)] public float _timeFactorAtTakeOff = 1.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _timeFactorAtSummit = 1.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _transitionToSummitDuration;
    }
}
