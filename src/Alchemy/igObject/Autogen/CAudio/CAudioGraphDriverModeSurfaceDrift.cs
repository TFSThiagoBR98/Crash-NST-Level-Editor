namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 192, align: 8)]
    public class CAudioGraphDriverModeSurfaceDrift : CAudioGraphDriverModeStickBased
    {
        [FieldAttr(ctr: 72)] public CAudioGraphDriverModeSurfaceDriftStageList? _driftStages;
        [FieldAttr(ctr: 80)] public int _driftLevel;
        [FieldAttr(ctr: 84)] public bool _activeOnSuccess;
        [FieldAttr(nst: 80, ctr: 88)] public igHandleMetaField _driftLoopingSound = new();
        [FieldAttr(nst: 88, ctr: 96)] public igHandleMetaField _driftActivateSound = new();
        [FieldAttr(nst: 96, ctr: 104)] public igHandleMetaField _driftDeactivateSound = new();
        [FieldAttr(nst: 104, ctr: 112)] public float _driftLoopingSoundMinVolume = 0.3f;
        [FieldAttr(nst: 108, ctr: 116)] public float _driftLoopingSoundVolumeChangePerSecond = 2.0f;
        [FieldAttr(nst: 112, ctr: 120)] public bool _onlyPlaySoundsOnGround = true;
        [FieldAttr(ctr: 124)] public float _topSpeedGraphInput;
        [FieldAttr(ctr: 128)] public float _startInputMax;
        [FieldAttr(ctr: 132)] public float _startInputMin;
        [FieldAttr(ctr: 136)] public float _maxIntroGraphInputChangePerSecond;
        [FieldAttr(nst: 120, ctr: 144)] public igHandleMetaField _playingDriftLoopingSound = new();
        [FieldAttr(nst: 128, ctr: 152)] public float _driftLoopingSoundInitialVolume;
        [FieldAttr(nst: 132, ctr: 156)] public float _driftLoopingSoundTargetVolume;
        [FieldAttr(nst: 136, ctr: 160)] public float _driftLoopingSoundCurrentVolume;
        [FieldAttr(ctr: 164)] public float _introCurrentInput;
        [FieldAttr(ctr: 168)] public float _introTargetInput;
        [FieldAttr(ctr: 172)] public float _currentInput;
        [FieldAttr(ctr: 176)] public bool _introActive;
        [FieldAttr(ctr: 180)] public igTimeMetaField _currentTime = new();
        [FieldAttr(ctr: 184)] public CAudioGraphDriverModeSurfaceDriftStage? _lastStage;
    }
}
