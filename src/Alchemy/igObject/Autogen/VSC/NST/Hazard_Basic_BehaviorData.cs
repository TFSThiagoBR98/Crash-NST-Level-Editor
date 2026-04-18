namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Basic_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _DestroyOnJump;
        [FieldAttr(nst: 41)] public bool _BouncePlayerUp;
        [FieldAttr(nst: 42)] public bool _DestroyOnSpin;
        [FieldAttr(nst: 43)] public bool _HurtPlayerOnContact;
        [FieldAttr(nst: 44)] public bool _StopMotion;
        [FieldAttr(nst: 48)] public float _AttackDelay;
        [FieldAttr(nst: 56)] public string? _Idle = null;
        [FieldAttr(nst: 64)] public string? _Attack = null;
        [FieldAttr(nst: 72)] public string? _CrashDeath_0x48 = null;
        [FieldAttr(nst: 80)] public bool _Bool_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 96)] public bool _Bool_0x60;
        [FieldAttr(nst: 104)] public igHandleMetaField _Sound_0x68 = new();
        [FieldAttr(nst: 112)] public bool _Bool_0x70;
        [FieldAttr(nst: 120)] public string? _String = null;
        [FieldAttr(nst: 128)] public bool _Bool_0x80;
        [FieldAttr(nst: 132)] public float _Float_0x84;
        [FieldAttr(nst: 136)] public igHandleMetaField _Sound_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 160)] public bool _Bool_0xa0;
        [FieldAttr(nst: 164)] public float _Float_0xa4;
        [FieldAttr(nst: 168)] public string? _CrashDeath_0xa8 = null;
        [FieldAttr(nst: 176)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 184)] public bool _Bool_0xb8;
    }
}
