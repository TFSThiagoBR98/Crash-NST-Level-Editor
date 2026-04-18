namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 160, align: 8)]
    public class CAudioGraphDriverModeSurfaceAccel : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56, ctr: 56)] public CAudioGraphDriverModeSurfaceAccelStageList? _accelStages;
        [FieldAttr(nst: 64, ctr: 64)] public float _topSpeedGraphInput = 1.0f;
        [FieldAttr(nst: 68, ctr: 68)] public float _slopeAccelTimeStretch = -0.4f;
        [FieldAttr(nst: 72, ctr: 72)] public float _turnAccelTimeStretch = -0.4f;
        [FieldAttr(nst: 76, ctr: 76)] public float _slopeTopSpeedChange = -0.2f;
        [FieldAttr(nst: 80, ctr: 80)] public float _turnTopSpeedChange = -0.2f;
        [FieldAttr(ctr: 84)] public float _slowedPitchModifier;
        [FieldAttr(ctr: 88)] public float _slowedPitchFade;
        [FieldAttr(ctr: 92)] public float _slowedSurfaceTimeStretch;
        [FieldAttr(ctr: 96)] public float _slowedSurfaceSpeedChange;
        [FieldAttr(ctr: 100)] public float _maxTimeFactor;
        [FieldAttr(nst: 84, ctr: 104)] public float _startInputMax = 1.0f;
        [FieldAttr(nst: 88, ctr: 108)] public float _maxIntroGraphInputChangePerSecond = 2.0f;
        [FieldAttr(nst: 92, ctr: 112)] public bool _loopFinalAccelStage;
        [FieldAttr(nst: 96, ctr: 116)] public float _inactiveMemoryTime = 1.0f;
        [FieldAttr(nst: 100, ctr: 120)] public float _introCurrentInput;
        [FieldAttr(nst: 104, ctr: 124)] public float _introTargetInput;
        [FieldAttr(nst: 108, ctr: 128)] public bool _introActive;
        [FieldAttr(nst: 112, ctr: 132)] public igTimeMetaField _currentTime = new();
        [FieldAttr(nst: 120, ctr: 136, refCount: false)] public CAudioGraphDriverModeSurfaceAccelStage? _lastStage;
        [FieldAttr(nst: 128, ctr: 144)] public CTimer? _inactiveTimer;
        [FieldAttr(nst: 136, ctr: 152)] public igTimeMetaField _memoryTime = new();
        [FieldAttr(nst: 140, ctr: 156)] public bool _resetOnNextActivation;
    }
}
