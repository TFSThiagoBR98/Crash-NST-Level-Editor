namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 8)]
    public class CGuiBehaviorOctaneTeamSelect : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _team1Placeable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _team2Placeable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _team3Placeable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _team4Placeable;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _twoTeamsAnim;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _threeTeamsAnim;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _threeTeamsOnlineAnim;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _fourTeamsAnim;
        [FieldAttr(ctr: 80)] public int _teamSizeTwoTeams;
        [FieldAttr(ctr: 84)] public int _teamSizeThreeTeams;
        [FieldAttr(ctr: 88)] public int _teamSizeFourTeams;
        [FieldAttr(ctr: 92)] public float _networkInputRequestDelay;
        [FieldAttr(ctr: 96)] public CPlayerHandleBoolHashTable? _ready;
        [FieldAttr(ctr: 104)] public igHandleMetaField _rootPlaceable = new();
        [FieldAttr(ctr: 112)] public string? _previousMenuName;
        [FieldAttr(ctr: 120)] public int _numPlayers;
        [FieldAttr(ctr: 124)] public int _numTeams;
        [FieldAttr(ctr: 128)] public int _maxPlayersPerTeam;
        [FieldAttr(ctr: 136)] public string? _emptyTeamWarningTitle;
        [FieldAttr(ctr: 144)] public string? _emptyTeamWarningBody;
        [FieldAttr(ctr: 152)] public igHandleMetaField _requestTeamSlot = new();
    }
}
