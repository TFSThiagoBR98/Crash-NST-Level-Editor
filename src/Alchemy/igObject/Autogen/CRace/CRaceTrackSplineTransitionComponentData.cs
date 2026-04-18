namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CRaceTrackSplineTransitionComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CEntityHandleList? _previousPositionPaths;
        [FieldAttr(ctr: 24)] public CEntityHandleList? _nextPositionPaths;
        [FieldAttr(ctr: 32)] public CEntityHandleList? _previousAIPaths;
        [FieldAttr(ctr: 40)] public CEntityHandleList? _nextAIPaths;
        [FieldAttr(ctr: 48)] public bool _incrementLap;
        [FieldAttr(ctr: 49)] public bool _isTeleporter;
    }
}
