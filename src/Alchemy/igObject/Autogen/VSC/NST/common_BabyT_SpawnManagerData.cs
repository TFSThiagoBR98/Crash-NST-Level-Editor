namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BabyT_SpawnManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Checkpoint = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
    }
}
