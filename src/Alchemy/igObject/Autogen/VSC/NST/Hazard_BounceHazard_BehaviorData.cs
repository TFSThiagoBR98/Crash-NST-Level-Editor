namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_BounceHazard_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _WarningDuration;
        [FieldAttr(nst: 44)] public float _HazardDuration;
        [FieldAttr(nst: 48)] public float _InitialDelay;
        [FieldAttr(nst: 52)] public float _IdleDuration;
        [FieldAttr(nst: 56)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bounce_Sfx = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Hazard_Sfx = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 88)] public string? _CrashDeath = null;
        [FieldAttr(nst: 96)] public string? _Bounce = null;
        [FieldAttr(nst: 104)] public igHandleMetaField _Hazard_Vfx = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Warning_Vfx = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Bounce_Vfx = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Idle_Vfx = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
    }
}
