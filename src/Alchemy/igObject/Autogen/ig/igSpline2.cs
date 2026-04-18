namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class igSpline2 : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igSplineControlPoint2List? _data;
        [FieldAttr(nst: 24, ctr: 24)] public igOrderedMapMetaField _distanceTable = new();
        [FieldAttr(nst: 72, ctr: 72)] public igSplineFloatKeyframeTrackTable? _floatTracks;
        [FieldAttr(nst: 80, ctr: 80)] public igSplineVec3fKeyframeTrackTable? _vec3fTracks;
        [FieldAttr(nst: 88, ctr: 88)] public igSplineRotationKeyframeTrackTable? _rotationTracks;
        [FieldAttr(nst: 96, ctr: 96)] public igSplineEventTrack? _events;
        [FieldAttr(nst: 104, ctr: 104)] public float _length;
        [FieldAttr(nst: 108, ctr: 108)] public bool _looping;
        [FieldAttr(nst: 109, ctr: 109)] public bool _precacheBezierPositions;
    }
}
