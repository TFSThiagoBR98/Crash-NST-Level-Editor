namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Motorcycle_Hazard_PoliceCar_Patrol_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public bool _Bool;
        [FieldAttr(nst: 76)] public float _Float;
        [FieldAttr(nst: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound_0x58 = new();
    }
}
