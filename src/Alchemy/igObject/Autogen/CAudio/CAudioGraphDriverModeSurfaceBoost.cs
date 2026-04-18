namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 136, align: 8)]
    public class CAudioGraphDriverModeSurfaceBoost : CAudioGraphDriverModeTargetBased
    {
        [FieldAttr(ctr: 64)] public CAudioGraphDriverModeSurfaceBoostStageList? _boostStages;
        [FieldAttr(nst: 72, ctr: 72)] public igHandleMetaField _boostActivationSound = new();
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _boostLoopingSound = new();
        [FieldAttr(ctr: 88)] public float _topSpeedGraphInput;
        [FieldAttr(ctr: 92)] public float _startInputMax;
        [FieldAttr(ctr: 96)] public float _maxIntroGraphInputChangePerSecond;
        [FieldAttr(nst: 88, ctr: 104)] public igHandleMetaField _playingBoostLoopingSound = new();
        [FieldAttr(ctr: 112)] public float _introCurrentInput;
        [FieldAttr(ctr: 116)] public float _introTargetInput;
        [FieldAttr(ctr: 120)] public bool _introActive;
        [FieldAttr(ctr: 124)] public igTimeMetaField _currentTime = new();
        [FieldAttr(ctr: 128)] public CAudioGraphDriverModeSurfaceBoostStage? _lastStage;
    }
}
