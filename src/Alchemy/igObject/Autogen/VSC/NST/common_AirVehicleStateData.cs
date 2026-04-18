namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_AirVehicleStateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Total = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_0x60 = new();
    }
}
