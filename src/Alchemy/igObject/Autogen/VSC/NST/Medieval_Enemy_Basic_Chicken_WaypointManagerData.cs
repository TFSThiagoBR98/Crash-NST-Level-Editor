namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class Medieval_Enemy_Basic_Chicken_WaypointManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Waypoint_List = new();
    }
}
