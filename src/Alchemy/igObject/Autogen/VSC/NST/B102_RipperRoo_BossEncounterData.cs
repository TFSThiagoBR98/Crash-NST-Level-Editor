namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class B102_RipperRoo_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _EntityVariable_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _EntityVariable_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Waypoint_0x40 = new();
        [FieldAttr(nst: 72)] public int _Int;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 88)] public igHandleMetaField _Camera = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _igEntity_List = new();
    }
}
