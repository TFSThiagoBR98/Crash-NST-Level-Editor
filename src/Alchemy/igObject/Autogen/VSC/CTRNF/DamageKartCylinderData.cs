namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class DamageKartCylinderData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Rumble_Data = new();
    }
}
