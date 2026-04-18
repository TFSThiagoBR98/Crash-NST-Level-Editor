namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiListItemPopulatorOctaneRaceRanking : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public bool _showOnlyFirstPlayer;
        [FieldAttr(ctr: 13)] public bool _hasPopulated;
        [FieldAttr(ctr: 14)] public bool _canPopulate;
        [FieldAttr(ctr: 16, refCount: false)] public igGuiListItemList? _items;
        [FieldAttr(ctr: 24)] public bool isCupRankingSecondScreen;
        [FieldAttr(ctr: 32)] public CRacerDroppedInfoList? racerDroppedInfoList;
    }
}
