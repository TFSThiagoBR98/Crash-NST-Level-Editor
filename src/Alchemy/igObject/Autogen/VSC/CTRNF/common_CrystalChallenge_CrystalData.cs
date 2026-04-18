namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CrystalChallenge_CrystalData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound_0x48 = new();
    }
}
