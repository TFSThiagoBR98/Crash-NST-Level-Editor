namespace Alchemy
{
    [ObjectAttr(ctr: 248, align: 8)]
    public class CPlayer : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _hero = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _kart = new();
        [FieldAttr(ctr: 32)] public EController _controller;
        [FieldAttr(ctr: 40)] public u64 _controllerButtonStates;
        [FieldAttr(ctr: 48)] public u64 _controllerButtonClicks;
        [FieldAttr(ctr: 56)] public u64 _controllerButtonReleases;
        [FieldAttr(ctr: 64)] public CDisableRequestManager? _controllerVibration;
        [FieldAttr(ctr: 72)] public igVec2fMetaField _leftControllerAxis = new();
        [FieldAttr(ctr: 80)] public igVec2fMetaField _rightControllerAxis = new();
        [FieldAttr(ctr: 88)] public igVec3fMetaField _movement = new();
        [FieldAttr(ctr: 104)] public string? _gamertag;
        [FieldAttr(ctr: 112)] public int _mapVoteIndex;
        [FieldAttr(ctr: 116)] public int _wheelsIndex;
        [FieldAttr(ctr: 120)] public int _paintIndex;
        [FieldAttr(ctr: 124)] public int _decalIndex;
        [FieldAttr(ctr: 128)] public int _stickerIndex;
        [FieldAttr(ctr: 136)] public string? _characterName;
        [FieldAttr(ctr: 144)] public igHandleMetaField _characterOutfit = new();
        [FieldAttr(ctr: 152)] public string? _kartName;
        [FieldAttr(ctr: 160)] public string? _displayGamertag;
        [FieldAttr(ctr: 168)] public u64 _onlineId;
        [FieldAttr(ctr: 176)] public EPlayerId _playerId;
        [FieldAttr(ctr: 180)] public int _index;
        [FieldAttr(ctr: 184)] public int _previousHeroEntityIdIndex;
        [FieldAttr(ctr: 188)] public bool _pendingJoin;
        [FieldAttr(ctr: 189)] public bool _joinedDuringMatchmaking;
        [FieldAttr(ctr: 192)] public float _skill;
        [FieldAttr(ctr: 196)] public bool _isSpectator;
        [FieldAttr(ctr: 200)] public int _netIndex;
        [FieldAttr(ctr: 208)] public string? _preloadCharacterName;
        [FieldAttr(ctr: 216)] public string? _preloadOutfitName;
        [FieldAttr(ctr: 224)] public bool _isPartyMember;
        [FieldAttr(ctr: 228)] public int _arenaTeamIndex;
        [FieldAttr(ctr: 232)] public bool _isDropped;
        [FieldAttr(ctr: 233)] public bool _isLobbyReady;
        [FieldAttr(ctr: 240)] public u64 _partyHostOnlineId;
    }
}
