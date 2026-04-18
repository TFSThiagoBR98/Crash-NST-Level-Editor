namespace Alchemy
{
    [ObjectAttr(nst: 576, ctr: 568, align: 8)]
    public class CActor : CPhysicalEntity
    {
        [ObjectAttr(size: 4)]
        public class NonPersistentBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _useCameraInputTransform;
            [FieldAttr(offset: 1, size: 1)] public bool _hasActorInputMapComponent;
            [FieldAttr(offset: 2, size: 1)] public bool _hasBaseVehicleControllerComponent;
            [FieldAttr(offset: 3, size: 1)] public bool _canDockTo;
            [FieldAttr(offset: 4, size: 1)] public bool _animClipDisplayHero;
            [FieldAttr(offset: 5, size: 1)] public bool _timelineDisplayHero;
        }

        [FieldAttr(nst: 296, ctr: 292)] public float mPainSoundTimer;
        [FieldAttr(nst: 300, ctr: 296)] public igTimeMetaField mDeathTime = new();
        [FieldAttr(nst: 304, ctr: 300)] public CEntityIDMetaField mLastHitEnt = new();
        [FieldAttr(nst: 308, ctr: 304)] public float mLastHitEntTime;
        [FieldAttr(nst: 312, ctr: 308)] public float mLastAttackedTime;
        [FieldAttr(nst: 316, ctr: 312)] public CEntityIDMetaField mLastAttackedBy = new();
        [FieldAttr(nst: 320, ctr: 316)] public uint mAttackNumber;
        [FieldAttr(nst: 328, ctr: 320)] public igHandleMetaField _player = new();
        [FieldAttr(nst: 336, ctr: 328)] public NonPersistentBitfield _nonPersistentBitfield = new();
        [FieldAttr(nst: 340, ctr: 332)] public bool mIsPlayerFastFlagHack;
        [FieldAttr(nst: 341, ctr: 333)] public bool mInitialized;
        [FieldAttr(nst: 342, ctr: 334)] public bool _inFreezeFrame;
        [FieldAttr(nst: 344, ctr: 336)] public igVec3fMetaField _linearVelocityBeforeFreezeFrame = new();
        [FieldAttr(nst: 356, ctr: 348)] public igVec3fMetaField _angularVelocityBeforeFreezeFrame = new();
        [FieldAttr(nst: 368, ctr: 360)] public igVec2fMetaField _currentMoveStickDirection = new();
        [FieldAttr(nst: 376, ctr: 368)] public CTransformMetaField _inputTransform = new();
        [FieldAttr(nst: 404, ctr: 396)] public float _heroShadowFade = 1.0f;
        [FieldAttr(nst: 408, ctr: 400)] public igHandleMetaField _lastGroundMaterialTouched = new();
        [FieldAttr(nst: 416, ctr: 408)] public bool _debugMove;
        [FieldAttr(nst: 424, ctr: 416)] public ActorInput? _actorInput;
        [FieldAttr(nst: 432, ctr: 424)] public CEnableRequestManager? _ignoreHitReacts;
        [FieldAttr(nst: 440, ctr: 432)] public CEnableRequestManager? _ignorePartialHitReacts;
        [FieldAttr(nst: 448, ctr: 440)] public CEnableRequestManager? _ignoreHitPushBack;
        [FieldAttr(nst: 456, ctr: 448)] public CTargetableFlagEnableStack? _targetableFlag;
        [FieldAttr(nst: 464, ctr: 456)] public CActorTimeScaleNonRefcountedList? _timeScaleList;
        [FieldAttr(nst: 472, ctr: 464)] public CTimeScaleEnableStack? _allowTimeScaling;
        [FieldAttr(nst: 480, ctr: 472)] public CActorTimeScale? _freezeFrameTimeScale;
        [FieldAttr(nst: 488, ctr: 480)] public CEnableRequestManager? _muted;
        [FieldAttr(nst: 496, ctr: 488)] public CChangeRequestList? _changeRequests;
        [FieldAttr(nst: 504, ctr: 496)] public string? _skinName = null;
        [FieldAttr(nst: 512, ctr: 504)] public bool _followingOther;
        [FieldAttr(nst: 520, ctr: 512, refCount: false)] public CActor? _followHero;
        [FieldAttr(nst: 528, ctr: 520)] public igHandleMetaField _behaviorComponentHandle = new();
        [FieldAttr(nst: 536, ctr: 528)] public CCombatTargetDataListList? _combatTargets;
        [FieldAttr(nst: 544, ctr: 536)] public igHandleMetaField _combatTargetProxy = new();
        [FieldAttr(nst: 552, ctr: 544)] public CCollectibleFilterList? _collectiblesFilters;
        [FieldAttr(nst: 560, ctr: 552)] public igHandleMetaField _enabledBaseVehicleController = new();
        [FieldAttr(nst: 568, ctr: 560)] public bool _canCollectCollectibles = true;
    }
}
