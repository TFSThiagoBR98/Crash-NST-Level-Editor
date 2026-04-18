namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class CameraSwitch_TempData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Camera_Base = new();
    }
}
