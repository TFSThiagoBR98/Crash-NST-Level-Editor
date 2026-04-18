namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Bounce_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _HazardEnabled;
        [FieldAttr(nst: 44)] public float _BounceSpeed;
        [FieldAttr(nst: 48)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 72)] public string? _CrashDeath = null;
        [FieldAttr(nst: 80)] public string? _Bounce = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public igHandleMetaField _Bounce_Vfx = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Idle_Vfx = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_Tag_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity_Tag_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 152)] public bool _Bool_0x98;
        [FieldAttr(nst: 153)] public bool _Bool_0x99;
    }
}
