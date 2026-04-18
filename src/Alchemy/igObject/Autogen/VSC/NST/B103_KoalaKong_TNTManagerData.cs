namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class B103_KoalaKong_TNTManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public igHandleMetaField _Waypoint_List = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity = new();
    }
}
