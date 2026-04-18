namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_DustCloudComponentData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Unnamed_BoltPoint = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _DustCloudBuff = new();
        [FieldAttr(nst: 56)] public float _Lifetime;
        [FieldAttr(nst: 64)] public igHandleMetaField _DustBuffVfx = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _AuthorityCloudVfx = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _NonAuthorityCloudVfx = new();
    }
}
