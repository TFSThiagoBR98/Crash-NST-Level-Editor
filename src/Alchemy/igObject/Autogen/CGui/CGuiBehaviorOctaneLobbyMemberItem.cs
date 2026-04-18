namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CGuiBehaviorOctaneLobbyMemberItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _playerName;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _playerIcon;
        [FieldAttr(ctr: 32)] public string? _waitingForPlayerString;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _localPlayerAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _partyMemberAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _otherMemberAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _readyAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _unreadyAnimation;
        [FieldAttr(ctr: 80)] public igHandleMetaField _player = new();
    }
}
