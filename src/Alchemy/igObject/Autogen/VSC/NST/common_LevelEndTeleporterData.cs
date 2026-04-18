namespace Alchemy
{
    [ObjectAttr(nst: 240, align: 4, metaType: typeof(CVscComponentData))]
    public class common_LevelEndTeleporterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsBonusRoundTeleporter;
        [FieldAttr(nst: 44)] public EigEaseType _MoveCrashCenterEaseType;
        [FieldAttr(nst: 48)] public float _MoveCrashCenterTime;
        [FieldAttr(nst: 52)] public float _MoveCrashCenterEaseRatioIn;
        [FieldAttr(nst: 56)] public float _MoveCrashCenterEaseRatioOut;
        [FieldAttr(nst: 64)] public igHandleMetaField _VfxTeleporterData = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Game_Bool_Variable_0x48 = new();
        [FieldAttr(nst: 80)] public string? _BehaviorEventCrashTeleportOutStart = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 104)] public bool _Bool_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _GemCollected = new();
        [FieldAttr(nst: 120)] public string? _String_0x78 = null;
        [FieldAttr(nst: 128)] public string? _String_0x80 = null;
        [FieldAttr(nst: 136)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 144)] public bool _Bool_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public ECrashSecretZones _E_Crash_Secret_Zones;
        [FieldAttr(nst: 160)] public igHandleMetaField _Game_Bool_Variable_0xa0 = new();
        [FieldAttr(nst: 168)] public float _Float_0xa8;
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public float _Float_0xb8;
        [FieldAttr(nst: 192)] public igHandleMetaField _Vfx_Effect_0xc0 = new();
        [FieldAttr(nst: 200)] public string? _String_0xc8 = null;
        [FieldAttr(nst: 208)] public float _Float_0xd0;
        [FieldAttr(nst: 212)] public float _Float_0xd4;
        [FieldAttr(nst: 216)] public igHandleMetaField _Vfx_Effect_0xd8 = new();
        [FieldAttr(nst: 224)] public bool _Bool_0xe0;
        [FieldAttr(nst: 228)] public float _Float_0xe4;
        [FieldAttr(nst: 232)] public igHandleMetaField _PlayerDied = new();
    }
}
