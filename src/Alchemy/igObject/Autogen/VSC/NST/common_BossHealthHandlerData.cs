namespace Alchemy
{
    [ObjectAttr(nst: 208, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BossHealthHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsBehaviorEventTakeHitOverrideOn;
        [FieldAttr(nst: 41)] public bool _IsBounceEnable;
        [FieldAttr(nst: 42)] public bool _IsDamageOnAttackIdentifierOnly;
        [FieldAttr(nst: 43)] public bool _IsGuiBossHealthBarBottomScreen_0x2b;
        [FieldAttr(nst: 48)] public igHandleMetaField _BounceDamage = new();
        [FieldAttr(nst: 56)] public float _OnTakeHitImmuneTime;
        [FieldAttr(nst: 60)] public float _CrashBounceForwardSpeed;
        [FieldAttr(nst: 64)] public igHandleMetaField _GuiBossHealthBar = new();
        [FieldAttr(nst: 72)] public int _HitCount;
        [FieldAttr(nst: 80)] public igHandleMetaField _GuiBossName = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _GuiBossPortrait = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _GuiBossHealthBarMaterial_0x60 = new();
        [FieldAttr(nst: 104)] public string? _BehaviorEventTakeHitOverride = null;
        [FieldAttr(nst: 112)] public igHandleMetaField _DamageOnAttackIdentifierList = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _String_List_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _String_List_0x80 = new();
        [FieldAttr(nst: 136)] public float _Float_0x88;
        [FieldAttr(nst: 140)] public bool _IsGuiBossHealthBarBottomScreen_0x8c;
        [FieldAttr(nst: 141)] public bool _Bool_0x8d;
        [FieldAttr(nst: 144)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _GuiBossHealthBarMaterial_0x98 = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _GuiBossHealthBarMaterial_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _GuiBossHealthBarMaterial_0xa8 = new();
        [FieldAttr(nst: 176)] public bool _IsGuiBossHealthBarBottomScreen_0xb0;
        [FieldAttr(nst: 177)] public bool _IsGuiBossHealthBarBottomScreen_0xb1;
        [FieldAttr(nst: 178)] public bool _Bool_0xb2;
        [FieldAttr(nst: 180)] public float _Float_0xb4;
        [FieldAttr(nst: 184)] public float _Float_0xb8;
        [FieldAttr(nst: 188)] public float _Float_0xbc;
        [FieldAttr(nst: 192)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 196)] public bool _Bool_0xc4;
        [FieldAttr(nst: 200)] public string? _String = null;
    }
}
