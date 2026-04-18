namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C2_HazardSpawnerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Spline_Marker = new();
        [FieldAttr(nst: 48)] public igVec3fMetaField _Vector3 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public bool _Bool;
    }
}
