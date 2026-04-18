namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_FloatingDropShadow_gData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
    }
}
