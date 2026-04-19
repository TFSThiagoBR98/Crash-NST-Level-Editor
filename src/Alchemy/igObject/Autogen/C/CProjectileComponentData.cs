namespace Alchemy
{
    [ObjectAttr(nst: 552, ctr: 544, align: 8)]
    public class CProjectileComponentData : CEntityComponentData
    {
        public enum EProjectileInitialPositionCollisionCheck
        {
            ePIPCC_Auto = 0,
            ePIPCC_On = 1,
            ePIPCC_Off = 2,
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _capInitialSpeed;
            [FieldAttr(offset: 1, size: 1)] public bool _orientToMovement = false;
            [FieldAttr(offset: 2, size: 1)] public bool _movementDelayUntilMessage;
            [FieldAttr(offset: 3, size: 1)] public bool _accelerateToFullSpeed;
            [FieldAttr(offset: 4, size: 1)] public bool _dieOnContact = false;
            [FieldAttr(offset: 5, size: 1)] public bool _dieOnDamage = false;
            [FieldAttr(offset: 6, size: 1)] public bool _onlyDamageTarget;
            [FieldAttr(offset: 7, size: 1)] public bool _damageOtherProjectiles;
            [FieldAttr(offset: 8, size: 1)] public bool _ignoreDieOnDamageForDestructibles;
            [FieldAttr(offset: 9, size: 1)] public bool _explodeOnDeath;
            [FieldAttr(offset: 10, size: 1)] public bool _followGroundDebugDraw;
            [FieldAttr(offset: 11, size: 1)] public bool _killWhenExceedingSlope;
            [FieldAttr(offset: 12, size: 1)] public bool _snapToFollowGroundDistance;
            [FieldAttr(offset: 13, size: 1)] public bool _stickAllowDamage;
            [FieldAttr(offset: 14, size: 1)] public bool _bounceOnContact;
            [FieldAttr(offset: 15, size: 1)] public bool _dieOnBounceComplete = false;
            [FieldAttr(offset: 16, size: 1)] public bool _alignDeathEffectsToLastBounce;
            [FieldAttr(offset: 17, size: 1)] public bool _boltSpawnEffect = false;
            [FieldAttr(offset: 18, size: 1)] public bool _deathEffectAligned = false;
            [FieldAttr(offset: 19, size: 1)] public bool _explodeEffectAligned = false;
            [FieldAttr(offset: 20, size: 1)] public bool _bounceEffectAligned = false;
            [FieldAttr(offset: 21, size: 1)] public bool _stickEffectAligned = false;
            [FieldAttr(offset: 22, size: 1)] public bool _killEffectOnStick;
            [FieldAttr(offset: 23, size: 1)] public bool _reticleEffectRemoveOnContact;
            [FieldAttr(offset: 24, size: 1)] public bool _stopSpawnSoundOnDeath;
            [FieldAttr(offset: 25, size: 1)] public bool _stopLoopSoundOnStick;
            [FieldAttr(offset: 26, size: 1)] public bool _sendDeathMessageToSelf;
            [FieldAttr(offset: 27, size: 1)] public bool _sendDeathMessageToParent;
            [FieldAttr(offset: 28, size: 1)] public bool _sendBounceCompleteMessageToSelf;
            [FieldAttr(offset: 29, size: 1)] public bool _sendBounceMessageOnEveryBounce;
            [FieldAttr(offset: 30, size: 1)] public bool _sendExceedingSlopeMessage;
            [FieldAttr(offset: 31, size: 1)] public bool _allowDeflection = false;
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _removeWhenBehindCamera;
            [FieldAttr(offset: 1, size: 1)] public bool _needsOnContactEvents;
            [FieldAttr(offset: 2, size: 1)] public bool _useAttackerForForwardTraceFiltering;
            [FieldAttr(offset: 3, size: 2)] public CProjectileComponentData.EProjectileInitialPositionCollisionCheck _checkInitialPositionCollision;
            [FieldAttr(offset: 5, size: 1)] public bool _stopHomingWithNoEntityTarget = false;
            [FieldAttr(offset: 6, size: 1)] public bool _homingPlanarForwardMatchVehicleMaxSpeed = false;
            [FieldAttr(offset: 7, size: 1)] public bool _followWater;
        }

        [FieldAttr(nst: 24, ctr: 16)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 28, ctr: 20)] public BitfieldStorage2 _bitfieldStorage2 = new();
        [FieldAttr(nst: 32, ctr: 24)] public CUpgradeableProjectileLifeTime? _lifetimeUpgradeable;
        [FieldAttr(nst: 40, ctr: 32)] public CUpgradeableProjectileLifeTime? _lifetimeLinear;
        [FieldAttr(nst: 48, ctr: 40)] public CUpgradeableProjectileLifeTime? _lifetimeArena;
        [FieldAttr(nst: 56, ctr: 48)] public CUpgradeableProjectileLifeTime? _lifetimeExpedition;
        [FieldAttr(nst: 64, ctr: 56)] public CUpgradeableProjectileMaxRange? _maxRangeUpgradeable;
        [FieldAttr(nst: 72, ctr: 64)] public CUpgradeableProjectileMaxRange? _maxRangeLinear;
        [FieldAttr(nst: 80, ctr: 72)] public CUpgradeableProjectileMaxRange? _maxRangeArena;
        [FieldAttr(nst: 88, ctr: 80)] public CUpgradeableProjectileMaxRange? _maxRangeExpedition;
        [FieldAttr(nst: 96, ctr: 88)] public EProjectileMovementMode _movementMode;
        [FieldAttr(nst: 104, ctr: 96)] public CUpgradeableProjectileSpeed? _speedUpgradeable;
        [FieldAttr(nst: 112, ctr: 104)] public CUpgradeableProjectileSpeed? _speedLinear;
        [FieldAttr(nst: 120, ctr: 112)] public CUpgradeableProjectileSpeed? _speedArena;
        [FieldAttr(nst: 128, ctr: 120)] public CUpgradeableProjectileSpeed? _speedExpedition;
        [FieldAttr(nst: 136, ctr: 128)] public CUpgradeableProjectileSpeed? _speedAir;
        [FieldAttr(nst: 144, ctr: 136)] public float _lobbedGravity = 1000.0f;
        [FieldAttr(nst: 148, ctr: 140)] public float _movementDelay;
        [FieldAttr(nst: 152, ctr: 144)] public float _initialSpeedWhenAccelerating;
        [FieldAttr(nst: 156, ctr: 148)] public float _acceleration = 1000.0f;
        [FieldAttr(nst: 160, ctr: 152)] public igVec3fMetaField _initialSpinAxis = new();
        [FieldAttr(nst: 172, ctr: 164)] public float _initialSpinSpeed;
        [FieldAttr(nst: 176, ctr: 168)] public float _collisionRadius = 5.0f;
        [FieldAttr(nst: 180, ctr: 172)] public float _entityCollisionDelay;
        [FieldAttr(nst: 184, ctr: 176)] public float _worldCollisionDelay;
        [FieldAttr(nst: 192, ctr: 184)] public CDamageData? _damage;
        [FieldAttr(nst: 200, ctr: 192)] public float _damageRadius = 50.0f;
        [FieldAttr(nst: 208, ctr: 200)] public CTriggerVolumeComponentData? _damageTriggerVolume;
        [FieldAttr(nst: 216, ctr: 208)] public float _damageAttackerDelay = -1.0f;
        [FieldAttr(nst: 224, ctr: 216)] public CUpgradeableProjectileExplodeRadius? _explodeRadiusUpgradeable;
        [FieldAttr(nst: 232, ctr: 224)] public CDamageData? _explodeDamage;
        [FieldAttr(nst: 240, ctr: 232)] public float _homingTurnRate = 180.0f;
        [FieldAttr(nst: 244, ctr: 236)] public float _homingTurnRateAcceleration;
        [FieldAttr(nst: 248, ctr: 240)] public float _homingTurnRateMax = 5400.0f;
        [FieldAttr(nst: 252, ctr: 244)] public CProjectileSpawnData.EAimingMethod _overrideAimingMethod;
        [FieldAttr(nst: 256, ctr: 248)] public float _homingDelay;
        [FieldAttr(nst: 260, ctr: 252)] public float _homingStopDistance;
        [FieldAttr(nst: 264, ctr: 256)] public float _homingPlanarForwardStrength = 1.0f;
        [FieldAttr(nst: 268, ctr: 260)] public float _homingPlanarForwardMaxSpeed = -1.0f;
        [FieldAttr(nst: 272, ctr: 264)] public float _homingPlanarLateralStrength = 0.5f;
        [FieldAttr(nst: 276, ctr: 268)] public float _homingPlanarLateralMaxSpeed = 500.0f;
        [FieldAttr(nst: 280, ctr: 272)] public float _lobbedCorrectionImpulseStrength;
        [FieldAttr(nst: 284, ctr: 276)] public float _desiredGroundDistance;
        [FieldAttr(nst: 288, ctr: 280)] public float _maxGroundSlopeToFollow = 45.0f;
        [FieldAttr(nst: 292, ctr: 284)] public float _groundTraceForwardDistance = 100.0f;
        [FieldAttr(nst: 296, ctr: 288)] public igHandleMetaField _targetWaterSurfaceMaterial = new();
        [FieldAttr(nst: 304, ctr: 296)] public uint _stickModes;
        [FieldAttr(nst: 308, ctr: 300)] public float _stickDuration = 2.0f;
        [FieldAttr(nst: 312, ctr: 304)] public CEntityMessage? _stickMessage;
        [FieldAttr(nst: 320, ctr: 312)] public igHandleMetaField _stickBoltPoint = new();
        [FieldAttr(nst: 328, ctr: 320)] public int _numBounces = 3;
        [FieldAttr(nst: 332, ctr: 324)] public float _bounceRestitution = 1.0f;
        [FieldAttr(nst: 336, ctr: 328)] public CUpgradeableVfx? _spawnEffectUpgradeable;
        [FieldAttr(nst: 344, ctr: 336)] public CUpgradeableVfx? _loopEffectUpgradeable;
        [FieldAttr(nst: 352, ctr: 344)] public igVfxManager.EffectKillType _loopEffectKillType;
        [FieldAttr(nst: 360, ctr: 352)] public CUpgradeableVfx? _deathEffectUpgradeable;
        [FieldAttr(nst: 368, ctr: 360)] public float _deathByTimeoutFadeDuration = 0.25f;
        [FieldAttr(nst: 376, ctr: 368)] public CUpgradeableVfx? _explodeEffectUpgradeable;
        [FieldAttr(nst: 384, ctr: 376)] public CUpgradeableVfx? _bounceEffectUpgradeable;
        [FieldAttr(nst: 392, ctr: 384)] public CUpgradeableVfx? _stickEffectUpgradeable;
        [FieldAttr(nst: 400, ctr: 392)] public CUpgradeableVfx? _bounceCompleteEffectUpgradeable;
        [FieldAttr(nst: 408, ctr: 400)] public CUpgradeableVfx? _reticleEffect;
        [FieldAttr(nst: 416, ctr: 408)] public igHandleMetaField _spawnSound = new();
        [FieldAttr(nst: 424, ctr: 416)] public igHandleMetaField _loopSound = new();
        [FieldAttr(nst: 432, ctr: 424)] public igHandleMetaField _deathSound = new();
        [FieldAttr(nst: 440, ctr: 432)] public igHandleMetaField _explodeSound = new();
        [FieldAttr(nst: 448, ctr: 440)] public igHandleMetaField _bounceSound = new();
        [FieldAttr(nst: 456, ctr: 448)] public igHandleMetaField _stickSound = new();
        [FieldAttr(nst: 464, ctr: 456)] public igHandleMetaField _bounceCompleteSound = new();
        [FieldAttr(nst: 472, ctr: 464)] public int _poolSize = 5;
        [FieldAttr(nst: 480, ctr: 472)] public CEntityMessage? _deathMessage;
        [FieldAttr(nst: 488, ctr: 480)] public CEntityMessage? _bounceCompleteMessage;
        [FieldAttr(nst: 496, ctr: 488)] public CTelegram? _unheldTelegram;
        [FieldAttr(nst: 504, ctr: 496)] public CEntityMessage? _exceedingSlopeMessage;
        [FieldAttr(nst: 512, ctr: 504)] public CUpgradeableModel? _model;
        [FieldAttr(nst: 520, ctr: 512)] public u8 _collisionDirtyCounter;
        [FieldAttr(nst: 528, ctr: 520)] public CPhysicsComponentData? _physicsData;
        [FieldAttr(nst: 536, ctr: 528)] public CCollisionMaterial? _collisionMaterial;
        [FieldAttr(nst: 544, ctr: 536)] public CPhysicsMotionProperties? _motionProperties;
    }
}
