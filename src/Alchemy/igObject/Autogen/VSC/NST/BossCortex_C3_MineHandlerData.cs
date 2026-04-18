namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C3_MineHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Damage_Data = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
    }
}
