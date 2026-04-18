namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Take_Hit_OnContactData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _HazardDeathState = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public bool _Bool_0x50;
        [FieldAttr(nst: 84)] public float _Float;
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(nst: 96)] public bool _Bool_0x60;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public string? _String_0x70 = null;
        [FieldAttr(nst: 120)] public bool _Bool_0x78;
        [FieldAttr(nst: 128)] public igHandleMetaField _Vfx_Effect_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Vfx_Effect_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Bolt_Point = new();
    }
}
