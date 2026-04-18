namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 56, align: 8)]
    public class CCutsceneData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _cutsceneName = null;
        [FieldAttr(nst: 24, ctr: 24)] public bool _skipEnabled = true;
        [FieldAttr(nst: 25, ctr: 25)] public bool _lockControls = true;
        [FieldAttr(nst: 26, ctr: 26)] public bool _invulnerable = true;
        [FieldAttr(nst: 27, ctr: 27)] public bool _targetable;
        [FieldAttr(nst: 28, ctr: 28)] public bool _hudEnabled;
        [FieldAttr(nst: 29, ctr: 29)] public bool _showCollectibles;
        [FieldAttr(nst: 30, ctr: 30)] public bool _showInteractionVfx = true;
        [FieldAttr(nst: 31, ctr: 31)] public bool _disableEntitiesWithComponent = true;
        [FieldAttr(nst: 32, ctr: 32)] public bool _useCameraForAuxiliaryVisibilityArea = true;
        [FieldAttr(nst: 33, ctr: 33)] public bool _hidePlayers;
        [FieldAttr(nst: 34, ctr: 34)] public bool _mutePlayers;
        [FieldAttr(nst: 35, ctr: 35)] public bool _pauseOnEnd;
        [FieldAttr(nst: 36, ctr: 36)] public bool _cameraIsSoundFocus = true;
        [FieldAttr(nst: 37, ctr: 37)] public bool _isSplitscreenAllowed = true;
        [FieldAttr(nst: 40, ctr: 40)] public int _framesToSkipRendering;
        [FieldAttr(nst: 44, ctr: 44)] public ESoundFocusPositionType _cameraSoundFocusPreCutsceneType;
        [FieldAttr(ctr: 48)] public bool _isFlybyIntro;
    }
}
