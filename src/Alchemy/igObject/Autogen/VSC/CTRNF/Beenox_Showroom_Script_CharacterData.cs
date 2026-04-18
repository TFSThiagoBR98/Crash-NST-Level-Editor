namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Beenox_Showroom_Script_CharacterData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Waypoint_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Waypoint_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 64)] public igVec3fMetaField _Vector3 = new();
    }
}
