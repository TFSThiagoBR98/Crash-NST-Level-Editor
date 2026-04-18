namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CRaceTrackSplineStats : igObject
    {
        [FieldAttr(ctr: 12)] public uint _splineHash;
        [FieldAttr(ctr: 16)] public string? _splineName;
        [FieldAttr(ctr: 24)] public uint _nextTransitionHash;
        [FieldAttr(ctr: 32)] public string? _nextTransitionName;
        [FieldAttr(ctr: 40)] public float _expectedTime;
        [FieldAttr(ctr: 44)] public int _completedCount;
        [FieldAttr(ctr: 48)] public int _startedCount;
        [FieldAttr(ctr: 56)] public CEntity? _splineEntity;
        [FieldAttr(ctr: 64)] public CEntity? _transitionEntity;
    }
}
