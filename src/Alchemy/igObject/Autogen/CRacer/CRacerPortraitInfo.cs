namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CRacerPortraitInfo : igObject
    {
        [FieldAttr(ctr: 16)] public CRacer? _racer;
        [FieldAttr(ctr: 24)] public igGuiPlaceable? _racerPlaceable;
        [FieldAttr(ctr: 32)] public CGuiBehaviorRaceLeadersItem? _raceLeaderItem;
        [FieldAttr(ctr: 40)] public igIntList? _nextPositionList;
    }
}
