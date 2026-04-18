namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4)]
    public class CCapsuleShape : CShape
    {
        [FieldAttr(nst: 16)] public igVec3fMetaField _bottom = new();
        [FieldAttr(nst: 28)] public igVec3fMetaField _top = new();
        [FieldAttr(nst: 40)] public float _radius = 100.0f;
    }
}
