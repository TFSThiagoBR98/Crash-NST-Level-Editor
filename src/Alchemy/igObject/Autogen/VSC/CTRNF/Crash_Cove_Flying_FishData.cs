namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Cove_Flying_FishData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound = new();
    }
}
