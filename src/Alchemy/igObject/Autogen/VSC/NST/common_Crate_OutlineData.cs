namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crate_OutlineData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _UsedEntityToSpawn = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _ReplacementEntity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _SwapSound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SwapVFX = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_Tag_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_Tag_0x50 = new();
    }
}
