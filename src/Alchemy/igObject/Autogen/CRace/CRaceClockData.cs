namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CRaceClockData : igObject
    {
        [FieldAttr(ctr: 12)] public ERaceClockMode _raceClockMode;
        [FieldAttr(ctr: 16)] public float _timeToCountDown;
        [FieldAttr(ctr: 20)] public float _lowTimeLeftThreshold;
    }
}
