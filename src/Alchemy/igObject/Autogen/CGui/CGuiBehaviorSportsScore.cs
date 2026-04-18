namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiBehaviorSportsScore : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _teamBlueScorePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _teamRedScorePlaceable;
        [FieldAttr(ctr: 32)] public igGuiAnimationCategory? _leadCategory;
        [FieldAttr(ctr: 40)] public EOctaneTeam _team;
        [FieldAttr(ctr: 48)] public igHandleMetaField _player = new();
    }
}
