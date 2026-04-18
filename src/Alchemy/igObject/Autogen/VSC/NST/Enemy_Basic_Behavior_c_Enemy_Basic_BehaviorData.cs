namespace Alchemy
{
    [ObjectAttr(nst: 320, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Basic_Behavior_c_Enemy_Basic_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _HurtPlayerOnContact;
        [FieldAttr(nst: 41)] public bool _DestroyOnContact;
        [FieldAttr(nst: 42)] public bool _DestroyOnSpin;
        [FieldAttr(nst: 43)] public bool _BouncePlayerUp;
        [FieldAttr(nst: 44)] public bool _DestroyOnJump;
        [FieldAttr(nst: 48)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 56)] public string? _CrashDeath = null;
        [FieldAttr(nst: 64)] public string? _JumpDeath = null;
        [FieldAttr(nst: 72)] public string? _Attack = null;
        [FieldAttr(nst: 80)] public string? _Despawn = null;
        [FieldAttr(nst: 88)] public string? _SpinDeath = null;
        [FieldAttr(nst: 96)] public string? _DangerContactDeath = null;
        [FieldAttr(nst: 104)] public string? _Idle = null;
        [FieldAttr(nst: 112)] public string? _Spawn = null;
        [FieldAttr(nst: 120)] public bool _Bool_0x78;
        [FieldAttr(nst: 121)] public bool _Bool_0x79;
        [FieldAttr(nst: 128)] public string? _String_0x80 = null;
        [FieldAttr(nst: 136)] public string? _AkuDeath = null;
        [FieldAttr(nst: 144)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x90 = new();
        [FieldAttr(nst: 152)] public bool _Bool_0x98;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xa0 = new();
        [FieldAttr(nst: 168)] public bool _Bool_0xa8;
        [FieldAttr(nst: 169)] public bool _Bool_0xa9;
        [FieldAttr(nst: 170)] public bool _Bool_0xaa;
        [FieldAttr(nst: 172)] public float _Float_0xac;
        [FieldAttr(nst: 176)] public igVec2fMetaField _Vec_2F = new();
        [FieldAttr(nst: 184)] public bool _Bool_0xb8;
        [FieldAttr(nst: 192)] public string? _String_0xc0 = null;
        [FieldAttr(nst: 200)] public igHandleMetaField _Game_Bool_Variable_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _Entity_Tag_0xd0 = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _Bolt_Point_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Bolt_Point_0xe8 = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _Game_Bool_Variable_0xf0 = new();
        [FieldAttr(nst: 248)] public bool _Bool_0xf8;
        [FieldAttr(nst: 256)] public string? _String_0x100 = null;
        [FieldAttr(nst: 264)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 272)] public bool _Bool_0x110;
        [FieldAttr(nst: 273)] public bool _Bool_0x111;
        [FieldAttr(nst: 274)] public bool _Bool_0x112;
        [FieldAttr(nst: 280)] public string? _String_0x118 = null;
        [FieldAttr(nst: 288)] public bool _Bool_0x120;
        [FieldAttr(nst: 289)] public bool _Bool_0x121;
        [FieldAttr(nst: 290)] public bool _Bool_0x122;
        [FieldAttr(nst: 291)] public bool _Bool_0x123;
        [FieldAttr(nst: 296)] public igHandleMetaField _Entity_Tag_0x128 = new();
        [FieldAttr(nst: 304)] public bool _Bool_0x130;
        [FieldAttr(nst: 305)] public bool _Bool_0x131;
        [FieldAttr(nst: 306)] public bool _Bool_0x132;
        [FieldAttr(nst: 308)] public float _Float_0x134;
        [FieldAttr(nst: 312)] public bool _Bool_0x138;
    }
}
