namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CWaypoint : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _occupied;
        [FieldAttr(nst: 20, ctr: 16)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 32, ctr: 28)] public igVec3fMetaField _rotation = new();
    }
}
