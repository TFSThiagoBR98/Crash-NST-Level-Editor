namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class B102_RipperRoo_CratesSpawnerManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public bool _Bool;
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint_List_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Waypoint_List_0x40 = new();
        [FieldAttr(nst: 72)] public float _Float;
    }
}
