namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_DarkRoom_AkuSpawnerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 72)] public float _Float;
    }
}
