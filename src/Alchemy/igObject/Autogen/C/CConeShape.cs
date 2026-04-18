namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4)]
    public class CConeShape : CShape
    {
        [FieldAttr(nst: 16)] public igVec3fMetaField _bottom = new();
        [FieldAttr(nst: 28)] public igVec3fMetaField _top = new();
        [FieldAttr(nst: 40)] public float _bottomRadius = 100.0f;
        [FieldAttr(nst: 44)] public int _segments = 8;
    }
}
