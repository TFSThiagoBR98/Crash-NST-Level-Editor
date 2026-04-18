namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Crab_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public string? _String_0x20 = null;
        [FieldAttr(ctr: 40)] public string? _String_0x28 = null;
        [FieldAttr(ctr: 48)] public int _Int;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Sound_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Sound_0x60 = new();
    }
}
