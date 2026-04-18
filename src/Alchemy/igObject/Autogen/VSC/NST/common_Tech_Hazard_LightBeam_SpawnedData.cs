namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Tech_Hazard_LightBeam_SpawnedData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
    }
}
