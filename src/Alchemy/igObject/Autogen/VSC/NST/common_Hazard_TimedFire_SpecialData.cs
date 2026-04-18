namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Hazard_TimedFire_SpecialData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Warning_Vfx = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Hazard_Vfx = new();
        [FieldAttr(nst: 88)] public float _HazardDuration_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point_0x60 = new();
        [FieldAttr(nst: 104)] public float _HazardDuration_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _Hazard_Sfx = new();
        [FieldAttr(nst: 120)] public string? _CrashDeath = null;
        [FieldAttr(nst: 128)] public igHandleMetaField _Bolt_Point_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Idle_Vfx = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 152)] public float _IdleDuration;
    }
}
