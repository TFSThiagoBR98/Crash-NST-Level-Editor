namespace Alchemy
{
    [ObjectAttr(ctr: 336, align: 8)]
    public class CGuiBehaviorFriendList : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _friendsListPlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiPlaceable? _noFriendsPlaceable;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiPlaceable? _arrowUpPlaceable;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiPlaceable? _arrowDownPlaceable;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiAnimationTag? _openAnimation;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiAnimationTag? _closeAnimation;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiAnimationTag? _noFriendsAnimation;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiAnimationTag? _joinEnabledAnimation;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiAnimationTag? _joinDisabledAnimation;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiAnimationTag? _inviteEnabledAnimation;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiAnimationTag? _inviteDisabledAnimation;
        [FieldAttr(ctr: 240, refCount: false)] public igGuiAnimationTag? _arrowUpEnabledAnimation;
        [FieldAttr(ctr: 248, refCount: false)] public igGuiAnimationTag? _arrowUpDisabledAnimation;
        [FieldAttr(ctr: 256, refCount: false)] public igGuiAnimationTag? _arrowUpPressAnimation;
        [FieldAttr(ctr: 264, refCount: false)] public igGuiAnimationTag? _arrowUpReleaseAnimation;
        [FieldAttr(ctr: 272, refCount: false)] public igGuiAnimationTag? _arrowDownEnabledAnimation;
        [FieldAttr(ctr: 280, refCount: false)] public igGuiAnimationTag? _arrowDownDisabledAnimation;
        [FieldAttr(ctr: 288, refCount: false)] public igGuiAnimationTag? _arrowDownPressAnimation;
        [FieldAttr(ctr: 296, refCount: false)] public igGuiAnimationTag? _arrowDownReleaseAnimation;
        [FieldAttr(ctr: 304)] public igTimer? _refreshTimer;
        [FieldAttr(ctr: 312)] public bool _inputReceived;
        [FieldAttr(ctr: 313)] public bool _arrowUpDisabled;
        [FieldAttr(ctr: 314)] public bool _arrowDownDisabled;
        [FieldAttr(ctr: 315)] public bool _noFriends;
        [FieldAttr(ctr: 320)] public igGuiAnimationCategory? _introCategory;
        [FieldAttr(ctr: 328)] public bool _gamercardButtonVisible;
    }
}
