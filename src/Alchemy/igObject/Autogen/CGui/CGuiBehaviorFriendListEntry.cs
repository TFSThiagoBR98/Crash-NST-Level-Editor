namespace Alchemy
{
    [ObjectAttr(ctr: 296, align: 8)]
    public class CGuiBehaviorFriendListEntry : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _gamertag;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _playerPicture;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _statusPlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiAnimationTag? _gainFocusAnimation;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiAnimationTag? _gainFocusIdleAnimation;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiAnimationTag? _loseFocusAnimation;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiAnimationTag? _loseFocusIdleAnimation;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiAnimationTag? _onlineAnimation;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiAnimationTag? _offlineAnimation;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiAnimationTag? _joinableAnimation;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiAnimationTag? _notJoinableAnimation;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiAnimationTag? _inviteAnimation;
        [FieldAttr(ctr: 240, refCount: false)] public igGuiAnimationTag? _noInviteAnimation;
        [FieldAttr(ctr: 248)] public igHandleMetaField _friendInfo = new();
        [FieldAttr(ctr: 256)] public bool _isOnline;
        [FieldAttr(ctr: 257)] public bool _isJoinable;
        [FieldAttr(ctr: 258)] public bool _receivedInvite;
        [FieldAttr(ctr: 264)] public string? _presence;
        [FieldAttr(ctr: 272)] public string? _joinableString;
        [FieldAttr(ctr: 280)] public string? _notJoinableString;
        [FieldAttr(ctr: 288)] public string? _offlineString;
    }
}
