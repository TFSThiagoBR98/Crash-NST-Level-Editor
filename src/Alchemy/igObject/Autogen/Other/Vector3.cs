namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class Vector3 : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _storage = new();
    }
}
