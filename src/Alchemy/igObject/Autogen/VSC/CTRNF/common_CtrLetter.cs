namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CtrLetter : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Bolt_Point = new();
    }
}
