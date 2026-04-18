namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Ride_CocoShip_HealthManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Material = new();
    }
}
