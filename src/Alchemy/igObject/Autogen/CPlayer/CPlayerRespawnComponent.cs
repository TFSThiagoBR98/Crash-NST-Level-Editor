namespace Alchemy
{
    [ObjectAttr(nst: 248, align: 8)]
    public class CPlayerRespawnComponent : CEntityComponent
    {
        public enum ERespawnType
        {
            eRT_RespawnTrigger = 0,
            eRT_InstantRespawnTrigger = 1,
            eRT_WaterRespawnTrigger = 2,
            eRT_IceRespawnTrigger = 3,
            eRT_CheckpointRespawn = 4,
            eRT_KillZ = 5,
            eRT_Instant = 6,
            eRT_PVPDeathDelayed = 7,
            eRT_Unknown = 8,
        }

        public enum EPointSelectionMethod
        {
            ePSM_DifficultyBased = 0,
            ePSM_Closest = 1,
        }

        public enum ERespawnState
        {
            eRS_None = 0,
            eRS_Delay = 1,
            eRS_WaitForSafe = 2,
            eRS_Searching = 3,
            eRS_TransitionIn = 4,
            eRS_TransitionOut = 5,
            eRS_WaitToFinish = 6,
        }

        [FieldAttr(nst: 48)] public CPlayerRespawnPointFinder? _finder;
        [FieldAttr(nst: 56)] public ERespawnState _respawnState;
        [FieldAttr(nst: 60)] public EPointSelectionMethod _pointSelectionMethod;
        [FieldAttr(nst: 64)] public igHandleMetaField _previousRespawnPoint = new();
        [FieldAttr(nst: 72)] public int _respawnAtSamePointCount;
        [FieldAttr(nst: 80)] public CTimer? _respawnTimer;
        [FieldAttr(nst: 88)] public bool _tetherDisabled;
        [FieldAttr(nst: 89)] public bool _targetable = true;
        [FieldAttr(nst: 90)] public bool _behaviorDisabled;
        [FieldAttr(nst: 92)] public ERespawnType _respawnType;
        [FieldAttr(nst: 96)] public CPlayerStartEntityHandleList? _respawnPoints;
        [FieldAttr(nst: 104)] public igHandleMetaField _chosenSpawnPoint = new();
        [FieldAttr(nst: 112)] public float _respawnDelayTime;
        [FieldAttr(nst: 120)] public igHandleMetaField _transitionInPlayerEffect = new();
        [FieldAttr(nst: 128)] public float _transitionInTimeSecs;
        [FieldAttr(nst: 136)] public igHandleMetaField _transitionOutPlayerEffect = new();
        [FieldAttr(nst: 144)] public float _transitionOutTimeSecs;
        [FieldAttr(nst: 148)] public bool _respawnOnGround = true;
        [FieldAttr(nst: 152)] public igVec3fMetaField _triggerPosition = new();
        [FieldAttr(nst: 164)] public float _timeRespawnButtonHeld;
        [FieldAttr(nst: 168)] public float _waitToFinishTime;
        [FieldAttr(nst: 172)] public float _waitToShowTime;
        [FieldAttr(nst: 176)] public igVec3fMetaField _cameraPosition = new();
        [FieldAttr(nst: 192)] public CCameraBase? _transitionOutCamera;
        [FieldAttr(nst: 200)] public CCameraBase? _transitionInCamera;
        [FieldAttr(nst: 208)] public bool _transitionFadeToBlack;
        [FieldAttr(nst: 212)] public float _transitionFadeFromBlackTime;
        [FieldAttr(nst: 216)] public float _fadeHoldTime;
        [FieldAttr(nst: 224)] public string? _transitionOutBehaviorState = null;
        [FieldAttr(nst: 232)] public CChangeRequestList? _changeRequests;
        [FieldAttr(nst: 240)] public bool _failedToRespawnAtOtherPlayer;
        [FieldAttr(nst: 241)] public bool _cameraTargetDisabled;
        [FieldAttr(nst: 242)] public bool _netIsInSafeState;
    }
}
