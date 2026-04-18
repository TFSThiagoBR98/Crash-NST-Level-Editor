namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igSplineControlPoint2 : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _tangentIn = new();
        [FieldAttr(nst: 40, ctr: 36)] public igVec3fMetaField _tangentOut = new();
        [FieldAttr(nst: 52, ctr: 48)] public bool _smooth = true;
    }
}
