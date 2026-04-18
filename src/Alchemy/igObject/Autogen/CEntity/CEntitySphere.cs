namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8, meta: true)]
    public class CEntitySphere : Object
    {
        [FieldAttr(nst: 32, ctr: 32)] public float _radius = 100.0f;
        [FieldAttr(nst: 36, ctr: 36)] public igVec3fMetaField _offset = new();
    }
}
