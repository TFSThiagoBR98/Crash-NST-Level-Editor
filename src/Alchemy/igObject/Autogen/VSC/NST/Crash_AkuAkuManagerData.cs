namespace Alchemy
{
    [ObjectAttr(nst: 384, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_AkuAkuManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _TargetBoltPoint = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _MaskOnCrashBoltPoint = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AkuAkuSpeedModifier_0x38 = new();
        [FieldAttr(nst: 64)] public igVec4ucMetaField _MultiplyColor = new();
        [FieldAttr(nst: 68)] public igVec4ucMetaField _BlendColor = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _AkuAkuDamage = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _FollowDummy = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _EntityVariable_id_iqqmjbtn_variable = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _AkuAkuMask = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _IlluminatedMask = new();
        [FieldAttr(nst: 112)] public float _DamagedInvulnerabilityTime;
        [FieldAttr(nst: 116)] public float _InvincibleTime;
        [FieldAttr(nst: 120)] public float _Height;
        [FieldAttr(nst: 124)] public float _FollowDistance;
        [FieldAttr(nst: 128)] public float _UpdateDelay;
        [FieldAttr(nst: 136)] public igHandleMetaField _IsIlluminatedGameVar = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _BonusRoundActive = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _StageThreeSound = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _InvincibilityOnPlayerSound = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _RemoveMaskSound = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _StageTwoSound = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _StageOneSound = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _TakeHitVO = new();
        [FieldAttr(nst: 224)] public igVec2fMetaField _BlendEmissive = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _RemoveMaskVFX = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _StageTwoVFX = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _DamagedInvulnerabilityVFX = new();
        [FieldAttr(nst: 256)] public igHandleMetaField _StageThreeVFX = new();
        [FieldAttr(nst: 264)] public igHandleMetaField _InvincibilityVFX = new();
        [FieldAttr(nst: 272)] public igHandleMetaField _InvincibilityMaskVFX = new();
        [FieldAttr(nst: 280)] public igHandleMetaField _StageOneVFX = new();
        [FieldAttr(nst: 288)] public igHandleMetaField _AkuAkuDamageVFX = new();
        [FieldAttr(nst: 296)] public igHandleMetaField _Game_Bool_Variable_0x128 = new();
        [FieldAttr(nst: 304)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 312)] public igHandleMetaField _MaskLightVFX = new();
        [FieldAttr(nst: 320)] public igHandleMetaField _Game_Bool_Variable_0x140 = new();
        [FieldAttr(nst: 328)] public igHandleMetaField _Game_Bool_Variable_0x148 = new();
        [FieldAttr(nst: 336)] public igHandleMetaField _EntityVariable_id_4h6ccd4o_variable = new();
        [FieldAttr(nst: 344)] public igHandleMetaField _Game_Bool_Variable_0x158 = new();
        [FieldAttr(nst: 352)] public float _Float;
        [FieldAttr(nst: 360)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 368)] public igHandleMetaField _Behavior_State_Group = new();
        [FieldAttr(nst: 376)] public igHandleMetaField _AkuAkuSpeedModifier_0x178 = new();
    }
}
