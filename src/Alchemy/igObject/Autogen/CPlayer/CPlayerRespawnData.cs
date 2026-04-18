namespace Alchemy
{
    [ObjectAttr(nst: 328, ctr: 320, align: 8)]
    public class CPlayerRespawnData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _respawnAtLastCheckpoint;
        [FieldAttr(nst: 20, ctr: 16)] public float _historyUpdateDistance = 25.0f;
        [FieldAttr(nst: 24, ctr: 20)] public int _historySkipOffsetActionPack = 4;
        [FieldAttr(nst: 28, ctr: 24)] public float _groundCheckUpDistance = 150.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _groundCheckDownDistance = 150.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _vehicleGroundDownCheckDistanceMultiplier = 4.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _vehicleGroundUpCheckDistanceMultiplier = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _blockerAcceptableGroundDifference = 30.0f;
        [FieldAttr(nst: 48, ctr: 44)] public float _blockerCheckRadius = 60.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _blockerCheckHeight = 250.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _minRespawnDistanceSelf;
        [FieldAttr(nst: 60, ctr: 56)] public float _maxRespawnDistanceSelf = 600.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _minRespawnDistanceOtherPlayer = 150.0f;
        [FieldAttr(nst: 68, ctr: 64)] public float _maxRespawnDistanceOtherPlayer = 600.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _fallbackDropHeightSelf = 150.0f;
        [FieldAttr(nst: 76, ctr: 72)] public float _fallbackDropHeightOtherPlayer = 150.0f;
        [FieldAttr(nst: 80, ctr: 76)] public float _respawnCooldown = 3.0f;
        [FieldAttr(nst: 88, ctr: 80)] public CDamageData? _respawnDamageData;
        [FieldAttr(nst: 96, ctr: 88)] public CDifficultySpecificFloat? _difficultyRespawnDamage;
        [FieldAttr(nst: 104, ctr: 96)] public CDifficultySpecificInt? _jumpRetryCount;
        [FieldAttr(nst: 112, ctr: 104)] public float _respawnDelayTime = 0.5f;
        [FieldAttr(nst: 116, ctr: 108)] public float _instantRespawnDelayTime = 0.1f;
        [FieldAttr(nst: 120, ctr: 112)] public igHandleMetaField _transitionInPlayerEffect = new();
        [FieldAttr(nst: 128, ctr: 120)] public float _transitionInTimeSecs = 0.5f;
        [FieldAttr(nst: 136, ctr: 128)] public igHandleMetaField _transitionOutPlayerEffect = new();
        [FieldAttr(nst: 144, ctr: 136)] public float _transitionOutTimeSecs = 0.5f;
        [FieldAttr(nst: 148, ctr: 140)] public float _waterRespawnDelayTime = 0.5f;
        [FieldAttr(nst: 152, ctr: 144)] public igHandleMetaField _waterTransitionInPlayerEffect = new();
        [FieldAttr(nst: 160, ctr: 152)] public float _waterTransitionInTimeSecs = 0.5f;
        [FieldAttr(nst: 168, ctr: 160)] public igHandleMetaField _waterTransitionOutPlayerEffect = new();
        [FieldAttr(nst: 176, ctr: 168)] public float _waterTransitionOutTimeSecs = 0.5f;
        [FieldAttr(nst: 180, ctr: 172)] public float _iceRespawnDelayTime = 0.5f;
        [FieldAttr(nst: 184, ctr: 176)] public igHandleMetaField _iceTransitionInPlayerEffect = new();
        [FieldAttr(nst: 192, ctr: 184)] public float _iceTransitionInTimeSecs = 0.5f;
        [FieldAttr(nst: 200, ctr: 192)] public igHandleMetaField _iceTransitionOutPlayerEffect = new();
        [FieldAttr(nst: 208, ctr: 200)] public float _iceTransitionOutTimeSecs = 0.5f;
        [FieldAttr(nst: 216, ctr: 208)] public igHandleMetaField _iceMaterialOverrideOnPlayerEffect = new();
        [FieldAttr(nst: 224, ctr: 216)] public float _iceRespawnFinishedMovementDelayTimeSecs = 1.0f;
        [FieldAttr(nst: 228, ctr: 220)] public float _iceRespawnWaitToFinishShowDelayTimeSecs = 0.5f;
        [FieldAttr(nst: 232, ctr: 224)] public float _pvpDeathRespawnDelayTime;
        [FieldAttr(nst: 240, ctr: 232)] public igHandleMetaField _pvpDeathTransitionInPlayerEffect = new();
        [FieldAttr(nst: 248, ctr: 240)] public float _pvpDeathTransitionInTimeSecs = 1.5f;
        [FieldAttr(nst: 256, ctr: 248)] public igHandleMetaField _pvpDeathTransitionOutPlayerEffect = new();
        [FieldAttr(nst: 264, ctr: 256)] public float _pvpDeathTransitionOutTimeSecs = 0.5f;
        [FieldAttr(nst: 268, ctr: 260)] public float _checkpointRespawnDelayTime;
        [FieldAttr(nst: 272, ctr: 264)] public igHandleMetaField _checkpointTransitionInPlayerEffect = new();
        [FieldAttr(nst: 280, ctr: 272)] public float _checkpointTransitionInTimeSecs = 1.0f;
        [FieldAttr(nst: 288, ctr: 280)] public igHandleMetaField _checkpointTransitionOutPlayerEffect = new();
        [FieldAttr(nst: 296, ctr: 288)] public float _checkpointTransitionOutTimeSecs = 0.3f;
        [FieldAttr(nst: 300, ctr: 292)] public bool _checkpointTransitionFadeToBlack = true;
        [FieldAttr(nst: 304, ctr: 296)] public float _checkpointFadeHoldTime = 0.2f;
        [FieldAttr(nst: 308, ctr: 300)] public float _transitionFadeFromBlackTime = 0.3f;
        [FieldAttr(nst: 312, ctr: 304)] public string? _checkpointTransitionOutBehaviorState = "SpawnIn";
        [FieldAttr(nst: 320, ctr: 312)] public float _checkpointRespawnWaitToFinishShowDelayTimeSecs = -1.0f;
        [FieldAttr(nst: 324, ctr: 316)] public float _cameraTargetBlendOutTime = 0.25f;
    }
}
