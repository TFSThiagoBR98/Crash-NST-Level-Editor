namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class C2_IrisDoor_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_0x58 = new();
        [FieldAttr(nst: 96)] public bool _Bool;
        [FieldAttr(nst: 104)] public igHandleMetaField _Entity_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Checkpoint = new();
    }
}
