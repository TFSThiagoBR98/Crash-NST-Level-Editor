namespace Alchemy
{
    [ObjectAttr(nst: 368, align: 16)]
    public class CReticleTargeterComponentData : CEntityComponentData
    {
        public enum ENoTargetAimType
        {
            eNTAT_IntoScreen = 0,
            eNTAT_EntityScreenRelative = 1,
            eNTAT_EntityPlaneRelative = 2,
        }

        public enum ENoTargetAimDistanceType
        {
            eNTADT_TargetingDistance = 0,
            eNTADT_ReticlePosition = 1,
        }

        [FieldAttr(nst: 24)] public igHandleMetaField _primaryReticleEffect = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _primaryReticleEffectTargetAcquired = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _primaryReticleEffectP1 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _primaryReticleEffectP2 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _primaryReticleEffectAlt = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _primaryReticleEffectAltP1 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _primaryReticleEffectAltP2 = new();
        [FieldAttr(nst: 80)] public EPlayerAttackType _altPrimaryReticlePlayerAttack = EPlayerAttackType.ePAT_Count;
        [FieldAttr(nst: 84)] public bool _usePrimaryReticleBolt;
        [FieldAttr(nst: 88)] public CBoltPoint? _primaryReticleBolt;
        [FieldAttr(nst: 96)] public float _primaryReticleScale = 1.0f;
        [FieldAttr(nst: 100)] public bool _keepConstantSize = true;
        [FieldAttr(nst: 112)] public igVec4fMetaField _defaultReticleColor = new();
        [FieldAttr(nst: 128)] public igVec4fMetaField _playerOneReticleColor = new();
        [FieldAttr(nst: 144)] public igVec4fMetaField _playerTwoReticleColor = new();
        [FieldAttr(nst: 160)] public igVec4fMetaField _targetAcquiredReticleColor = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _secondaryReticleEffect = new();
        [FieldAttr(nst: 184)] public CBoltPoint? _secondaryReticleBolt;
        [FieldAttr(nst: 192)] public igHandleMetaField _lockReticleEffect = new();
        [FieldAttr(nst: 200)] public CBoltPoint? _lockReticleBolt;
        [FieldAttr(nst: 208)] public EPlayerAttackType _inactiveDuringPlayerAttack = EPlayerAttackType.ePAT_Count;
        [FieldAttr(nst: 212)] public EPlayerAttackType _activeOnlyDuringPlayerAttack = EPlayerAttackType.ePAT_Count;
        [FieldAttr(nst: 216)] public CScreenspaceTargetManager.EScreenspaceTargetListType _targetListType;
        [FieldAttr(nst: 224)] public CReticleTargeterDifficultyData? _difficultyData;
        [FieldAttr(nst: 232)] public CScreenspaceTarget.EScreenspaceTargetShape _targetShape = CScreenspaceTarget.EScreenspaceTargetShape.eSSTS_Circle;
        [FieldAttr(nst: 236)] public igVec2fMetaField _boxAcquireTargetingExtents = new();
        [FieldAttr(nst: 244)] public igVec2fMetaField _boxDropTargetingExtents = new();
        [FieldAttr(nst: 252)] public float _circleAcquireTargetingRadius = 40.0f;
        [FieldAttr(nst: 256)] public float _circleDropTargetingRadius;
        [FieldAttr(nst: 260)] public float _maxSeparationDepth = 1.0f;
        [FieldAttr(nst: 264)] public float _targetingMinKeepTargetDepth;
        [FieldAttr(nst: 268)] public float _targetingDistance = 1.0f;
        [FieldAttr(nst: 272)] public float _maxTargetingAcquireDistance = 12000.0f;
        [FieldAttr(nst: 276)] public float _screenspaceMaxTargetingRangeMultiplier = 1.0f;
        [FieldAttr(nst: 280)] public float _targetingClampPadding;
        [FieldAttr(nst: 284)] public bool _allowTargetingBehindVehicle;
        [FieldAttr(nst: 288)] public float _reticleVisibilityDuration = 3.0f;
        [FieldAttr(nst: 292)] public bool _reticleVisibilityEnabled = true;
        [FieldAttr(nst: 293)] public bool _reticleVisibleAtStart;
        [FieldAttr(nst: 296)] public EXBUTTON _fireButton = EXBUTTON.X;
        [FieldAttr(nst: 300)] public EXBUTTON _hideButton = EXBUTTON.MAX;
        [FieldAttr(nst: 304)] public CQueryFilter? _filterTargets;
        [FieldAttr(nst: 312)] public ECombatTargetList _targetList;
        [FieldAttr(nst: 316)] public bool _targetingSquareStickInput = true;
        [FieldAttr(nst: 317)] public bool _passengerTargeting;
        [FieldAttr(nst: 318)] public bool _gunnerTargeting;
        [FieldAttr(nst: 320)] public float _maxHorizontalReticleSpeed = 1.0f;
        [FieldAttr(nst: 324)] public float _maxVerticalReticleSpeed = 1.0f;
        [FieldAttr(nst: 328)] public float _reticleScreenEdgeOffset = 0.05f;
        [FieldAttr(nst: 332)] public bool _onlyUpdateLockedTargetOnInput;
        [FieldAttr(nst: 333)] public bool _dropTargetIfReticleMovesOffTarget;
        [FieldAttr(nst: 336)] public ENoTargetAimType _noTargetAimType;
        [FieldAttr(nst: 340)] public ENoTargetAimDistanceType _noTargetAimDistanceType;
        [FieldAttr(nst: 344)] public float _entityRelativeRayLength = 2.0f;
        [FieldAttr(nst: 348)] public bool _externalSystemReticleControl;
        [FieldAttr(nst: 352)] public float _externalOffset = 8000.0f;
        [FieldAttr(nst: 356)] public float _reticleWorldPositionDampingFactor = 0.5f;
    }
}
