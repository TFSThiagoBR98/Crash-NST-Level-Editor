namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Navigation_Arrow_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Waypoint_List = new();
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public float _Float;
    }
}
