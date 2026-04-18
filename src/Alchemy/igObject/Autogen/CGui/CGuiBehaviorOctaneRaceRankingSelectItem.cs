namespace Alchemy
{
    [ObjectAttr(ctr: 224, align: 8)]
    public class CGuiBehaviorOctaneRaceRankingSelectItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _racerFinishedAnim;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _racerNotFinishedAnim;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _racerSwapInIncrease;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _racerSwapInDecrease;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _racerSwapOutIncrease;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _racerSwapOutDecrease;
        [FieldAttr(ctr: 64)] public igGuiAnimationCategory? _animationSwapCategory;
        [FieldAttr(ctr: 72)] public igGuiAnimationCategory? _animationFinishedCategory;
        [FieldAttr(ctr: 80)] public bool _isCupTotalPointsScreen;
        [FieldAttr(ctr: 81)] public bool _isAnimating;
        [FieldAttr(ctr: 82)] public bool _isFinished;
        [FieldAttr(ctr: 83)] public bool _finishedRaceBeforeDropping;
        [FieldAttr(ctr: 84)] public bool _incomingRacerPositionIsIncreasing;
        [FieldAttr(ctr: 88)] public int _position;
        [FieldAttr(ctr: 92)] public EFlags _team;
        [FieldAttr(ctr: 96)] public EPlayerType _playerType;
        [FieldAttr(ctr: 104)] public CPlayer? _player;
        [FieldAttr(ctr: 112)] public igHandleMetaField _driver = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _racer = new();
        [FieldAttr(ctr: 128)] public EOctaneRaceModes _raceMode;
        [FieldAttr(ctr: 136)] public CRacerList? _teamCaptains;
        [FieldAttr(ctr: 144)] public bool _onlyShowPlayerOne;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiPlaceable? _timePlaceable;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiPlaceable? _positionPlaceable;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiPlaceable? _playerContourPlaceable;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiPlaceable? _addedPointsText;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiPlaceable? _scoreText;
        [FieldAttr(ctr: 208)] public bool _isTeamBattle;
        [FieldAttr(ctr: 209)] public bool _alwaysGetRacerByPosition;
        [FieldAttr(ctr: 210)] public igVec4ucMetaField _playerTextColor = new();
        [FieldAttr(ctr: 214)] public igVec4ucMetaField _onlinePlayerTextColor = new();
    }
}
