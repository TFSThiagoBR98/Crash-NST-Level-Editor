namespace Alchemy
{
    [ObjectAttr(nst: 200, ctr: 200, align: 8)]
    public class CCutsceneStage : igObject
    {
        public enum EStageState
        {
            eSS_Invalid = -1,
            eSS_Unprepared = 0,
            eSS_Preparing = 1,
            eSS_Waiting = 2,
            eSS_Playing = 3,
            eSS_PlayingMovie = 4,
            eSS_Finished = 5,
        }

        [FieldAttr(nst: 16, ctr: 16)] public JuiceScene? _rootScene;
        [FieldAttr(nst: 24, ctr: 24)] public CCutsceneActorList? _performers;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fMetaField _origin = new();
        [FieldAttr(nst: 44, ctr: 44)] public igVec3fMetaField _orientation = new();
        [FieldAttr(nst: 56, ctr: 56)] public string? _name = null;
        [FieldAttr(nst: 64, ctr: 64)] public float _secondsUntilPrepared;
        [FieldAttr(nst: 68, ctr: 68)] public float _secondsInCutscene;
        [FieldAttr(nst: 72, ctr: 72)] public float _startTime;
        [FieldAttr(nst: 76, ctr: 76)] public float _endTime;
        [FieldAttr(nst: 80, ctr: 80)] public EStageState _currentState;
        [FieldAttr(nst: 84, ctr: 84)] public EStageState _nextState;
        [FieldAttr(nst: 88, ctr: 88)] public bool _paused;
        [FieldAttr(nst: 89, ctr: 89)] public bool _pausedAtEnd;
        [FieldAttr(nst: 92, ctr: 92)] public float _seekingFrameRate = 10.0f;
        [FieldAttr(nst: 96, ctr: 96)] public bool _isSeeking;
        [FieldAttr(nst: 104, ctr: 104)] public CutsceneActionPlayCameraList? _cameras;
        [FieldAttr(nst: 112, ctr: 112)] public igHandleMetaField _subtitlesProject = new();
        [FieldAttr(nst: 120, ctr: 120)] public bool _isMovie;
        [FieldAttr(nst: 121, ctr: 121)] public bool _shutdownOnFinish;
        [FieldAttr(nst: 124, ctr: 124)] public int _movieFrameCount;
        [FieldAttr(nst: 128, ctr: 128)] public igHandleMetaField _cutsceneEntity = new();
        [FieldAttr(nst: 136, ctr: 136)] public CEntityMessage? _cutsceneEntityMessage;
        [FieldAttr(nst: 144, ctr: 144)] public bool _pauseOnEnd;
        [FieldAttr(nst: 148, ctr: 148)] public int _shotNumber;
        [FieldAttr(nst: 152, ctr: 152)] public float _cameraTransitionInTime;
        [FieldAttr(nst: 156, ctr: 156)] public float _cameraTransitionOutTime;
        [FieldAttr(nst: 160, ctr: 160)] public COnCutsceneStagePreparedDelegate? _onCutsceneStagePrepared;
        [FieldAttr(nst: 168, ctr: 168)] public COnCutsceneStagePreparedEventList? _onCutsceneStagePreparedList;
        [FieldAttr(nst: 176, ctr: 176)] public COnCutsceneStageFinishedDelegate? _onCutsceneStageFinished;
        [FieldAttr(nst: 184, ctr: 184)] public COnCutsceneStageFinishedEventList? _onCutsceneStageFinishedList;
        [FieldAttr(nst: 192, ctr: 192)] public EGameStateKey _cutsceneStartedCountGameState = EGameStateKey.eGSK_None;
    }
}
