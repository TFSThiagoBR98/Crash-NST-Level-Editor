namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igSplineRotationKeyframeTrack : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igSplineRotationKeyframeList? _data;
        [FieldAttr(nst: 24, ctr: 24)] public igOrderedMapMetaField _distanceTable = new();
        [FieldAttr(nst: 72, ctr: 72)] public float _length;
        [FieldAttr(nst: 76, ctr: 76)] public bool _looping;
    }
}
