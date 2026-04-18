namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class COctaneMapTimeTrialData : igObject
    {
        [FieldAttr(ctr: 16)] public COctaneTimeTrialList? _mapTimeTrialTimes;
        [FieldAttr(ctr: 24)] public COctaneTimeTrialList? _mapRelicRaceTimes;
        [FieldAttr(ctr: 32)] public COctaneTimeTrialData? _mapBestLap;
    }
}
