namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 184, align: 8)]
    public class CProjectileSpawnData : igObject
    {
        public enum EAimingMethod
        {
            eAM_NoAiming = 0,
            eAM_AimAtTarget = 1,
            eAM_AimAtAimedPosition = 2,
            eAM_AimAtTargetThenPosition = 3,
            eAM_LeadTarget = 4,
        }

        public enum ELobbedTargettingMode
        {
            eLTM_SolveForSpeed = 0,
            eLTM_SolveForAngle = 1,
            eLTM_SolveForAngleMax = 2,
            eLTM_SolveForGravity = 3,
        }

        public enum ESpawnPositionMode
        {
            eSPM_AbsoluteWorldSpace = 0,
            eSPM_WorldSpaceOffset = 1,
            eSPM_EntityLocalOffset = 2,
            eSPM_BoltLocalOffset = 3,
            eSPM_SpawnOrientationOffset = 4,
        }

        public enum ESpawnOrientationMode
        {
            eSOM_RelativeToWorld = 0,
            eSOM_RelativeToEntity = 1,
            eSOM_RelativeToBolt = 2,
        }

        public enum EReplicationMode
        {
            eRM_False = 0,
            eRM_True = 1,
            eRM_Default = 2,
            eRM_Entity = 3,
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public ECombatTargetSelect _combatTargetSelect;
            [FieldAttr(offset: 3, size: 3)] public ECombatTargetList _combatTargetList;
            [FieldAttr(offset: 6, size: 3)] public CProjectileSpawnData.EAimingMethod _aimingMethod;
            [FieldAttr(offset: 9, size: 2)] public CProjectileSpawnData.ELobbedTargettingMode _lobbedTargettingMode;
            [FieldAttr(offset: 11, size: 1)] public bool _fakeAiming;
            [FieldAttr(offset: 12, size: 1)] public bool _aimAtGround;
            [FieldAttr(offset: 13, size: 3)] public CProjectileSpawnData.ESpawnPositionMode _positionRelativeMode;
            [FieldAttr(offset: 16, size: 2)] public CProjectileSpawnData.ESpawnOrientationMode _angleRelativeMode;
            [FieldAttr(offset: 18, size: 1)] public bool _useAttackerScale;
            [FieldAttr(offset: 19, size: 1)] public bool _useAttackerSpeedOverride;
            [FieldAttr(offset: 20, size: 1)] public bool _adjustProjectileSpeedAndRange;
            [FieldAttr(offset: 21, size: 4)] public int _spawnCount;
            [FieldAttr(offset: 25, size: 1)] public bool _spreadDamagesOnce;
            [FieldAttr(offset: 26, size: 1)] public bool _spreadForceAimed;
            [FieldAttr(offset: 27, size: 1)] public bool _spreadAroundTarget;
            [FieldAttr(offset: 28, size: 1)] public bool _spreadSingleSpawnEffect;
            [FieldAttr(offset: 29, size: 1)] public bool _useSpecialTeamForProjectile;
            [FieldAttr(offset: 30, size: 1)] public bool _spawnAsChildOfAttacker;
            [FieldAttr(offset: 31, size: 1)] public bool _boltSpawnEffect;
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _aimYaw;
            [FieldAttr(offset: 1, size: 1)] public bool _aimPitch;
            [FieldAttr(offset: 2, size: 1)] public bool _useRootEntityForAttackerSpeedOverride;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnWhenOffScreen;
            [FieldAttr(offset: 4, size: 3)] public CProjectileSpawnData.EReplicationMode _netReplicate;
            [FieldAttr(offset: 7, size: 3)] public ENetworkSendPriority _netSendPriority;
            [FieldAttr(offset: 10, size: 1)] public bool _netReliable;
            [FieldAttr(offset: 11, size: 1)] public bool _recalculateTargetingOnPeer;
        }

        [FieldAttr(nst: 16, ctr: 12)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 20, ctr: 16)] public BitfieldStorage2 _bitfieldStorage2 = new();
        [FieldAttr(nst: 24, ctr: 24)] public CBoltPoint? _targetBoltPoint;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fMetaField _fakeAimingOffset = new();
        [FieldAttr(nst: 44, ctr: 44)] public igRangedFloatMetaField _randomAimOffsetRadius = new();
        [FieldAttr(nst: 52, ctr: 52)] public igVec3fMetaField _additionalAimingAngleOffset = new();
        [FieldAttr(nst: 64, ctr: 64)] public u8 _maxAimAngleFromSpawnYaw = 180;
        [FieldAttr(nst: 65, ctr: 65)] public u8 _maxAimAngleFromSpawnPitch = 180;
        [FieldAttr(nst: 68, ctr: 68)] public igVec3fMetaField _positionOffset = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec3fMetaField _positionOffsetRandomRange = new();
        [FieldAttr(nst: 92, ctr: 92)] public igVec3fMetaField _angleOffset = new();
        [FieldAttr(nst: 104, ctr: 104)] public igVec3fMetaField _angleOffsetRandomRange = new();
        [FieldAttr(nst: 120, ctr: 120)] public CBoltPoint? _boltPoint;
        [FieldAttr(nst: 128, ctr: 128)] public CBoltPoint? _passengerBoltPoint;
        [FieldAttr(nst: 136, ctr: 136)] public float _initialSpeedOverride = -1.0f;
        [FieldAttr(nst: 140, ctr: 140)] public float _spreadAngle = 90.0f;
        [FieldAttr(nst: 144, ctr: 144)] public float _spreadRandomYawRange;
        [FieldAttr(nst: 148, ctr: 148)] public float _spreadRandomPitchRange;
        [FieldAttr(nst: 152, ctr: 152)] public igRangedFloatMetaField _spreadTargetOffset = new();
        [FieldAttr(nst: 160, ctr: 160)] public float _spreadTargetAngleOffset = 20.0f;
        [FieldAttr(nst: 164, ctr: 164)] public float _spreadHorizontalRange;
        [FieldAttr(nst: 168, ctr: 168)] public float _spreadDepthArcRange;
        [FieldAttr(nst: 176, ctr: 176)] public igHandleMetaField _spawnEffect = new();
    }
}
