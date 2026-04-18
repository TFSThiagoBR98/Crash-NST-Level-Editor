namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CBoxShape : CShape
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 40, ctr: 36)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 52, ctr: 48)] public igVec3fMetaField _max = new();
    }
}
