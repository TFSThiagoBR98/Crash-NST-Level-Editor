namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CLapTTRData : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _position1 = new();
        [FieldAttr(ctr: 24)] public igVec3fMetaField _position2 = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _position3 = new();
        [FieldAttr(ctr: 48)] public igVec3fMetaField _position4 = new();
        [FieldAttr(ctr: 60)] public igVec3fMetaField _position5 = new();
        [FieldAttr(ctr: 72)] public igVec3fMetaField _position6 = new();
        [FieldAttr(ctr: 84)] public igVec3fMetaField _position7 = new();
        [FieldAttr(ctr: 96)] public igVec3fMetaField _position8 = new();
    }
}
