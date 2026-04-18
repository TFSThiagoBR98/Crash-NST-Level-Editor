namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class B203_TinyTiger_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _EntityVariable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public float _Float;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Checkpoint = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Query_Filter = new();
    }
}
