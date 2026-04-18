namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class CGuiBehaviorKartMarker : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public float _maxDistance;
        [FieldAttr(ctr: 16)] public float _minDistance;
        [FieldAttr(ctr: 20)] public float _minScale;
        [FieldAttr(ctr: 24)] public float _maxScale;
        [FieldAttr(ctr: 28)] public igVec3fMetaField _positionOffset = new();
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _onscreenAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _offscreenAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _leadGainedAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _leadLostAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiPlaceable? _flag;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiPlaceable? _playerTagPlaceable;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _raceLayoutAnimation;
        [FieldAttr(ctr: 96)] public igGuiAnimationCategory? _visibleCategory;
        [FieldAttr(ctr: 104)] public igGuiAnimationCategory? _leadCategory;
        [FieldAttr(ctr: 112)] public igHandleMetaField _racerHandle = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _screenPlayerHandle = new();
        [FieldAttr(ctr: 128)] public bool _offScreen;
        [FieldAttr(ctr: 129)] public bool _hasLead;
        [FieldAttr(ctr: 132)] public EFlags _team;
        [FieldAttr(ctr: 136)] public bool _isBattle;
        [FieldAttr(ctr: 137)] public bool _onlineIDVisible;
        [FieldAttr(ctr: 138)] public bool _keepDisplayTextUpdated;
    }
}
