namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CCylinderShape : CShape
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _bottom = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _top = new();
        [FieldAttr(nst: 40, ctr: 36)] public float _radius = 100.0f;
        [FieldAttr(nst: 44, ctr: 40)] public int _numVerts = 16;
    }
}
