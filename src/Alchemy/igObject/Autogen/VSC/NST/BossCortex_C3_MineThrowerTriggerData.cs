namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C3_MineThrowerTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Waypoint_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Waypoint_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
    }
}
