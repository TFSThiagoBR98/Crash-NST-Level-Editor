namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class igSplinePoint : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _position = new();
        [FieldAttr(ctr: 24)] public igVec3fMetaField _rotation = new();
        [FieldAttr(ctr: 36)] public float _ratioAtPoint;
        [FieldAttr(ctr: 40)] public float _segmentLength;
        [FieldAttr(ctr: 44)] public float _distanceAtPoint;
    }
}
