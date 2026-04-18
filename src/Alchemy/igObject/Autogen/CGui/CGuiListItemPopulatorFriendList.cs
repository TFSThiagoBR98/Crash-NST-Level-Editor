namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorFriendList : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public EPlayerId _playerId;
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _noFriendAnimation;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _noFriendText;
    }
}
