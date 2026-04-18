namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CKartDriftTrajectoryStep : igObject
    {
        [FieldAttr(ctr: 12)] public float _angularAmplitudeMidPoint;
        [FieldAttr(ctr: 16)] public float _angularAmplitudeProDeviation;
        [FieldAttr(ctr: 20)] public float _angularAmplitudeCounterDeviation;
    }
}
