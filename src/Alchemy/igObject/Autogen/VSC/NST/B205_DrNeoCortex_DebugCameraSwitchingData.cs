namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class B205_DrNeoCortex_DebugCameraSwitchingData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Camera_List = new();
    }
}
