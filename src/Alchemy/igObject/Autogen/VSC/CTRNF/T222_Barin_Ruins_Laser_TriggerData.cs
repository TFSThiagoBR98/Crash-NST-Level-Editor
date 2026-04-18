namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T222_Barin_Ruins_Laser_TriggerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect = new();
    }
}
