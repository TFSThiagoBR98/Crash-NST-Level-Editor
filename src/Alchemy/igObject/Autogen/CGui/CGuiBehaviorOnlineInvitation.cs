namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 232, align: 8)]
    public class CGuiBehaviorOnlineInvitation : igGuiBehavior
    {
        public enum EOnlineInviteState
        {
            eOIS_Closed = 0,
            eOIS_Opening = 1,
            eOIS_Open = 2,
            eOIS_Closing = 3,
        }

        public enum EOnlineInviteIcon
        {
            eOII_None = 0,
            eOII_PlayerDisconnect = 1,
            eOII_ServerDisconnect = 2,
            eOII_ServerConnect = 3,
            eOII_Envelope = 4,
            eOII_Portrait = 5,
        }

        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiAnimationTag? _playerOneOpenAnimation;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAnimationTag? _playerOneCloseAnimation;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiAnimationTag? _playerTwoOpenAnimation;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiAnimationTag? _playerTwoCloseAnimation;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiAnimationTag? _loopAnimation;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igGuiPlaceable? _playerOneInfoPlaceable;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igGuiPlaceable? _playerOneGamerPlaceable;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igGuiPlaceable? _playerTwoInfoPlaceable;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igGuiPlaceable? _playerTwoGamerPlaceable;
        [FieldAttr(nst: 88, ctr: 88, refCount: false)] public igGuiPlaceable? _invitationIconPlaceable;
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igGuiPlaceable? _playerDisconnectIconPlaceable;
        [FieldAttr(nst: 104, ctr: 104, refCount: false)] public igGuiPlaceable? _serverDisconnectIconPlaceable;
        [FieldAttr(nst: 112, ctr: 112, refCount: false)] public igGuiPlaceable? _serverConnectIconPlaceable;
        [FieldAttr(nst: 120, ctr: 120, refCount: false)] public igGuiPlaceable? _exclamationIconPlaceable;
        [FieldAttr(nst: 128, ctr: 128, refCount: false)] public igGuiPlaceable? _playerPortraitPlaceable;
        [FieldAttr(nst: 136, ctr: 136)] public string? _joinGamerText = null;
        [FieldAttr(ctr: 144)] public string? _playerJoined;
        [FieldAttr(nst: 144, ctr: 152)] public string? _waitGamerText = null;
        [FieldAttr(nst: 152, ctr: 160)] public string? _joinNotDisturbText = null;
        [FieldAttr(nst: 160, ctr: 168)] public string? _inviteGamerText = null;
        [FieldAttr(nst: 168, ctr: 176)] public string? _hostLeaveGamerText = null;
        [FieldAttr(nst: 176, ctr: 184)] public string? _peerLeaveGamerText = null;
        [FieldAttr(nst: 184, ctr: 192)] public string? _leaveMessageText = null;
        [FieldAttr(nst: 192, ctr: 200)] public float _timeout;
        [FieldAttr(nst: 196, ctr: 204)] public float _buttonHoldAbortJoinTime;
        [FieldAttr(nst: 200, ctr: 208)] public float _timeElapsed;
        [FieldAttr(nst: 204, ctr: 212)] public float _buttonHoldTime;
        [FieldAttr(nst: 208, ctr: 216)] public EOnlineInviteState _state;
        [FieldAttr(nst: 212, ctr: 220)] public EOnlineInviteIcon _icon;
        [FieldAttr(nst: 216, ctr: 224)] public bool _exclamationVisible;
    }
}
