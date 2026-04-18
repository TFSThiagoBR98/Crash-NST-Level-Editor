namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Ride_Bike_Rough_RoadData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Collision_Material = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
    }
}
