namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 152, align: 8)]
    public class CPlayerAttackData : igObject
    {
        public enum EJumpAttackOption
        {
            eJAO_Disabled = 0,
            eJAO_Normal = 1,
            eJAO_Custom = 2,
            eJAO_CustomDoNotCancel = 3,
            eJAO_CustomDelayGroundTransition = 4,
            eJAO_DoNotCancel = 5,
        }

        [FieldAttr(nst: 16, ctr: 16)] public string? _attackEvent = null;
        [FieldAttr(nst: 24, ctr: 24)] public string? _attackState = null;
        [FieldAttr(nst: 32, ctr: 32)] public string? _cancelEvent = null;
        [FieldAttr(nst: 40, ctr: 40)] public EJumpAttackOption _jumpAttackOption;
        [FieldAttr(nst: 48, ctr: 48)] public string? _jumpAttackEvent = null;
        [FieldAttr(nst: 56, ctr: 56)] public string? _jumpAttackState = null;
        [FieldAttr(nst: 64, ctr: 64)] public string? _jumpAttackCancelEvent = null;
        [FieldAttr(nst: 72, ctr: 72)] public string? _jumpAttackLandEvent = null;
        [FieldAttr(nst: 80, ctr: 80)] public CSkillUpgradeFilter? _jumpAttackUpgradeFilter;
        [FieldAttr(nst: 88, ctr: 88)] public float _hangTimeMaxDuration = 1.0f;
        [FieldAttr(nst: 92, ctr: 92)] public bool _disabledDuringFall;
        [FieldAttr(nst: 93, ctr: 93)] public bool _disabledDuringDoubleJump;
        [FieldAttr(nst: 96, ctr: 96)] public float _maxAllowedFallDistance;
        [FieldAttr(nst: 100, ctr: 100)] public float _minimumGroundDistance = 50.0f;
        [FieldAttr(nst: 104, ctr: 104)] public bool _requiresRunningState;
        [FieldAttr(nst: 105, ctr: 105)] public bool _authorityOnly;
        [FieldAttr(nst: 106, ctr: 106)] public bool _isToggleAbility;
        [FieldAttr(nst: 107, ctr: 107)] public bool _triggerOnHeldButton;
        [FieldAttr(nst: 108, ctr: 108)] public float _onHeldButtonWindowTime;
        [FieldAttr(nst: 112, ctr: 112)] public bool _cancelOnReleasedButton;
        [FieldAttr(nst: 113, ctr: 113)] public bool _interruptOtherAttacks;
        [FieldAttr(nst: 114, ctr: 114)] public bool _canBeInterrupted;
        [FieldAttr(nst: 116, ctr: 116)] public float _cooldownTime;
        [FieldAttr(nst: 120, ctr: 120)] public CUpgradeableFloat? _upgradeableCooldownTime;
        [FieldAttr(nst: 128, ctr: 128)] public CSkillUpgradeFilter? _skillUpgradeFilter;
        [FieldAttr(nst: 136, ctr: 136)] public bool _blockWhenCrouchedUnderCollision;
        [FieldAttr(nst: 137, ctr: 137)] public bool _checkExtraButtons;
        [FieldAttr(nst: 140, ctr: 140)] public EXBUTTON _extraButton1 = EXBUTTON.MAX;
        [FieldAttr(nst: 144, ctr: 144)] public EXBUTTON _extraButton2 = EXBUTTON.MAX;
    }
}
