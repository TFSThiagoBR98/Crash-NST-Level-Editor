namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CSphereShape : CShape
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 28, ctr: 24)] public float _radius = 50.0f;
    }
}
