namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Factory_Enemy_Spike_Robot_Night_VFXData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool_0x28;
        [FieldAttr(nst: 41)] public bool _Bool_0x29;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
    }
}
