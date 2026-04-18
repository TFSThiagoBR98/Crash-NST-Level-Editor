namespace Alchemy
{
    [ObjectAttr(nst: 288, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_DamageManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _RespawnInvulnerability;
        [FieldAttr(nst: 48)] public igHandleMetaField _Wampu = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _StartingLives = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _CrashRidingPlatform_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _PlayerDied = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _AkuAkuCount = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _PlayerDeathCount = new();
        [FieldAttr(nst: 112)] public string? _DefaultTakeHitDeathClip = null;
        [FieldAttr(nst: 120)] public string? _DefaultFallingDeathClip_0x78 = null;
        [FieldAttr(nst: 128)] public igHandleMetaField _Game_Bool_Variable_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Minigame_Data_0x88 = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Game_Bool_Variable_0x98 = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 168)] public string? _DefaultFallingDeathClip_0xa8 = null;
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public float _Float;
        [FieldAttr(nst: 192)] public igHandleMetaField _Game_Float_Variable_0xc0 = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _Game_Float_Variable_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _CrashRidingPlatform_0xd0 = new();
        [FieldAttr(nst: 216)] public string? _String_0xd8 = null;
        [FieldAttr(nst: 224)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Minigame_Data_0xe8 = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _Game_Bool_Variable_0xf8 = new();
        [FieldAttr(nst: 256)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 264)] public igHandleMetaField _Fade_In_Preset_Data = new();
        [FieldAttr(nst: 272)] public igHandleMetaField _Game_Bool_Variable_0x110 = new();
        [FieldAttr(nst: 280)] public igHandleMetaField _Minigame_Data_0x118 = new();
    }
}
