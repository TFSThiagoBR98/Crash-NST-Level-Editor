namespace Alchemy
{
    [ObjectAttr(nst: 256, align: 8)]
    public class CVehicleTransitionComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _startEnabled = true;
        [FieldAttr(nst: 25)] public bool _useBasicTransitionWhenForced;
        [FieldAttr(nst: 32)] public CVehicleSection? _vehicleSection;
        [FieldAttr(nst: 40)] public igHandleMetaField _defaultGameplayCamera = new();
        [FieldAttr(nst: 48)] public float _defaultGameplayCameraBlendTime = 1.0f;
        [FieldAttr(nst: 52)] public float _reactivationDelay = -1.0f;
        [FieldAttr(nst: 56)] public EVehicleType _requiredVehicleType;
        [FieldAttr(nst: 64)] public igHandleMetaField _transitionSuccessMusicSettings = new();
        [FieldAttr(nst: 72)] public float _transitionSuccessMusicSettingsDelay;
        [FieldAttr(nst: 80)] public igHandleMetaField _afterTransitionTeleportDestination = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _beforeTransitionTeleportDestination = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _fadeOut = new();
        [FieldAttr(nst: 104)] public float _fadeOutDelay;
        [FieldAttr(nst: 112)] public igHandleMetaField _fadeIn = new();
        [FieldAttr(nst: 120)] public float _fadeInDelay;
        [FieldAttr(nst: 128)] public CVehicleBoostData? _afterTransitionBoost;
        [FieldAttr(nst: 136)] public bool _fireTransitionBehaviorEvent;
        [FieldAttr(nst: 137)] public bool _splineAfterTransform;
        [FieldAttr(nst: 138)] public bool _useAlternateGateAnimation;
        [FieldAttr(nst: 144)] public igHandleMetaField _extraSplineEntity = new();
        [FieldAttr(nst: 152)] public float _forwardTransformMomentum;
        [FieldAttr(nst: 156)] public float _forwardTransformMomentumAlt;
        [FieldAttr(nst: 160)] public float _extraSplineSectionChangeDelay = -1.0f;
        [FieldAttr(nst: 168)] public CBoltPoint? _vfxBolt;
        [FieldAttr(nst: 176)] public CWaypoint? _vfxSpawnPoint;
        [FieldAttr(nst: 184)] public float _vfxRadiusApproach = 1000.0f;
        [FieldAttr(nst: 192)] public igHandleMetaField _enableEffect = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _loopEffect = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _transitionSuccessEffect = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _enableSound = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _loopSound = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _transitionSuccessSound = new();
        [FieldAttr(nst: 240)] public CSetGameSpeedMessage? _setGameSpeedMessage;
        [FieldAttr(nst: 248)] public float _sendGameSpeedMessageDelay;
    }
}
