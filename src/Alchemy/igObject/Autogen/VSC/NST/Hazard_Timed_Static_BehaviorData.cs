namespace Alchemy
{
    [ObjectAttr(nst: 208, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Timed_Static_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _WarningDuration;
        [FieldAttr(nst: 44)] public float _HazardDuration_0x2c;
        [FieldAttr(nst: 48)] public float _InitialDelay;
        [FieldAttr(nst: 52)] public float _IdleDuration;
        [FieldAttr(nst: 56)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Hazard_Sfx = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 80)] public string? _CrashDeath = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Hazard_Vfx = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Warning_Vfx = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Idle_Vfx = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Bolt_Point_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Bolt_Point_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Bolt_Point_0x80 = new();
        [FieldAttr(nst: 136)] public string? _String_0x88 = null;
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public bool _Bool_0x98;
        [FieldAttr(nst: 160)] public string? _String_0xa0 = null;
        [FieldAttr(nst: 168)] public bool _Bool_0xa8;
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public float _HazardDuration_0xb8;
        [FieldAttr(nst: 188)] public bool _Bool_0xbc;
        [FieldAttr(nst: 192)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 200)] public bool _Bool_0xc8;
    }
}
