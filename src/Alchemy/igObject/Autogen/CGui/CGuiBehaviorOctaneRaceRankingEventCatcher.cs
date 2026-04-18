namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorOctaneRaceRankingEventCatcher : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public CGuiListItemPopulatorOctaneRaceRanking? _raceRankingPopulator;
        [FieldAttr(ctr: 24)] public bool isCupRankingSecondScreen;
    }
}
