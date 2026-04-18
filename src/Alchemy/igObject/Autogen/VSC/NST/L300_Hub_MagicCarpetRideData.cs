namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class L300_Hub_MagicCarpetRideData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Sound = new();
    }
}
