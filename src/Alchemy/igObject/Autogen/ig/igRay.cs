namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class igRay : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _pos = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _dir = new();
        [FieldAttr(nst: 40, ctr: 36)] public float _len;
    }
}
