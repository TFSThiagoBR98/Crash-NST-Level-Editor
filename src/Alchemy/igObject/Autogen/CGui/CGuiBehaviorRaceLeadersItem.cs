namespace Alchemy
{
    [ObjectAttr(ctr: 208, align: 8)]
    public class CGuiBehaviorRaceLeadersItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _portrait;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _positionText;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _playerTagText;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _timeText;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _addedPointsText;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiPlaceable? _scoreText;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiPlaceable? _finishedFlag;
        [FieldAttr(ctr: 72)] public int _position;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiPlaceable? _contourPlaceable;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiPlaceable? _animatable;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _redHitAnimation;
        [FieldAttr(ctr: 104, refCount: false)] public igGuiAnimationTag? _greenHitAnimation;
        [FieldAttr(ctr: 112, refCount: false)] public igGuiAnimationTag? _racerFinishedAnimation;
        [FieldAttr(ctr: 120)] public igVec4ucMetaField _localPlayerTextColor = new();
        [FieldAttr(ctr: 124)] public igVec4ucMetaField _remotePlayerTextColor = new();
        [FieldAttr(ctr: 128)] public bool _hasUpdatedPosition;
        [FieldAttr(ctr: 129)] public bool _isAnimating;
        [FieldAttr(ctr: 136)] public igHandleMetaField _racer = new();
        [FieldAttr(ctr: 144)] public igVec3fMetaField _sourceAnimatablePosition = new();
        [FieldAttr(ctr: 156)] public igVec3fMetaField _sourcePlaceablePosition = new();
        [FieldAttr(ctr: 168)] public igVec3fMetaField _targetPlaceablePosition = new();
        [FieldAttr(ctr: 180)] public float _pendingAnimationTime;
        [FieldAttr(ctr: 184)] public float _totalAnimationTime;
        [FieldAttr(ctr: 188)] public float _translateAmountX;
        [FieldAttr(ctr: 192)] public EigEaseType _easeType;
        [FieldAttr(ctr: 196)] public EigEaseMode _easeMode;
        [FieldAttr(ctr: 200)] public bool _hasRaceFinished;
        [FieldAttr(ctr: 201)] public bool _raceFinishedAnimationPlayed;
        [FieldAttr(ctr: 202)] public bool _isOnlineRace;
        [FieldAttr(ctr: 203)] public bool _isDroppedPlayer;
    }
}
