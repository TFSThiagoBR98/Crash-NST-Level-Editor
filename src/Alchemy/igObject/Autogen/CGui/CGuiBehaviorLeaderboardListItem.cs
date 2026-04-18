namespace Alchemy
{
    [ObjectAttr(ctr: 272, align: 8)]
    public class CGuiBehaviorLeaderboardListItem : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _positionPlaceable;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _timePlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiPlaceable? _pointsPlaceable;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiPlaceable? _lockIconPlaceable;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiAnimationTag? _initializeAnimation;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiAnimationTag? _playerInitializeAnimation;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiAnimationTag? _focusGainAnimation;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiAnimationTag? _focusLostAnimation;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiAnimationTag? _playerFocusGainAnimation;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiAnimationTag? _playerFocusLostAnimation;
        [FieldAttr(ctr: 240)] public bool _isPlayerScore;
        [FieldAttr(ctr: 248)] public igHandleMetaField _friendInfo = new();
        [FieldAttr(ctr: 256)] public u64 _userId;
        [FieldAttr(ctr: 264)] public bool _showGamerCardPrompt;
    }
}
