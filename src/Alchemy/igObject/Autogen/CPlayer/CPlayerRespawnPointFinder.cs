namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CPlayerRespawnPointFinder : igObject
    {
        public enum EState
        {
            eS_None = 0,
            eS_InProgress = 1,
            eS_Success = 2,
            eS_Failure = 3,
        }

        public enum ESearchState
        {
            eSS_None = 0,
            eSS_GroundCheck = 1,
            eSS_BlockerCheck = 2,
        }

        [FieldAttr(nst: 16)] public EState _state;
        [FieldAttr(nst: 20)] public ESearchState _searchState;
        [FieldAttr(nst: 24)] public int _cursor;
        [FieldAttr(nst: 28)] public int _offset;
        [FieldAttr(nst: 32)] public igVec3fMetaField _resultPosition = new();
        [FieldAttr(nst: 44)] public bool _resultIsOnGround = true;
        [FieldAttr(nst: 48)] public CPlayerRespawnGroundChecker? _groundChecker;
        [FieldAttr(nst: 56)] public CPlayerRespawnBlockerChecker? _blockerChecker;
        [FieldAttr(nst: 64)] public igHandleMetaField _respawnActor = new();
        [FieldAttr(nst: 72)] public bool _isVehicle;
        [FieldAttr(nst: 73)] public bool _isLandVehicle;
        [FieldAttr(nst: 74)] public bool _needsGroundCheck;
        [FieldAttr(nst: 76)] public EigBlockingType _blockingType;
        [FieldAttr(nst: 80)] public bool _forceMultiplayerLogic;
        [FieldAttr(nst: 84)] public igVec3fMetaField _positionAtRespawnRequest = new();
    }
}
