namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CHeroScreenGrabAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 33)] public bool _motionBlurRestore;
        [FieldAttr(ctr: 34)] public bool _bloomRestore;
        [FieldAttr(ctr: 35)] public bool _wasThreadedDraw;
        [FieldAttr(ctr: 36)] public EPlayerId _playerId;
        [FieldAttr(ctr: 40)] public CCutsceneCamera? _gameplayScreenGrabCamera;
        [FieldAttr(ctr: 48)] public CSmokeAction? _screenShotAction;
        [FieldAttr(ctr: 56)] public EHeroScreenGrabActionState _actionState;
        [FieldAttr(ctr: 60)] public EGrabType _grabType;
        [FieldAttr(ctr: 64)] public EGameplayGrabState _gameplayGrabState;
        [FieldAttr(ctr: 68)] public bool _updateScreenShotRender;
        [FieldAttr(ctr: 72)] public string? _baseScreenGrabName;
    }
}
