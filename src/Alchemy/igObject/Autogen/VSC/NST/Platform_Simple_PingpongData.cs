namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class Platform_Simple_PingpongData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Spline = new();
    }
}
