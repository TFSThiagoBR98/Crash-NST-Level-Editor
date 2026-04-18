namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CGuiListItemPopulatorOctaneLobbyMembers : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public int _realPlayerItemCount;
        [FieldAttr(ctr: 16)] public int _lastCPlayerCount;
    }
}
