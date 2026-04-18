namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4)]
    public class CRaceTrackSplineSegmentStats : igObject
    {
        [FieldAttr(ctr: 12)] public uint _splineHash;
        [FieldAttr(ctr: 16)] public int _segmentIndex;
        [FieldAttr(ctr: 20)] public float _driveLookaheadOffset;
        [FieldAttr(ctr: 24)] public float _driftLookaheadOffset;
        [FieldAttr(ctr: 28)] public float _driveSpeed;
        [FieldAttr(ctr: 32)] public float _driftSpeed;
        [FieldAttr(ctr: 36)] public float _longestOffset2;
        [FieldAttr(ctr: 40)] public float _splineRelativeStartTime;
        [FieldAttr(ctr: 44)] public bool _updated;
        [FieldAttr(ctr: 45)] public bool _previousIsFaulty;
        [FieldAttr(ctr: 46)] public bool _touchGroundOnce;
        [FieldAttr(ctr: 48)] public ESplineOffsetState _lastDriveOffsetState;
        [FieldAttr(ctr: 52)] public ESplineOffsetState _lastDriftOffsetState;
        [FieldAttr(ctr: 56)] public float _longestDriveOffset2;
        [FieldAttr(ctr: 60)] public float _longestDriftOffset2;
        [FieldAttr(ctr: 64)] public float _currentDriveSpeed;
        [FieldAttr(ctr: 68)] public float _currentDriftSpeed;
        [FieldAttr(ctr: 72)] public int _consecutiveCorrect;
        [FieldAttr(ctr: 76)] public int _completedSegmentCount;
        [FieldAttr(ctr: 80)] public int _startedSegmentCount;
    }
}
