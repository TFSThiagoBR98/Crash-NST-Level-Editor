namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class T154_Oxide_Station_MotherShipData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(ctr: 48)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(ctr: 60)] public float _Float;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect = new();
    }
}
