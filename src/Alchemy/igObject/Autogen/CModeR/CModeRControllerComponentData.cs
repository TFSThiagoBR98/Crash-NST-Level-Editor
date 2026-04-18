namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CModeRControllerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CRaceClockData? _raceClockData;
        [FieldAttr(ctr: 24)] public bool _giveBoost;
        [FieldAttr(ctr: 25)] public bool _giveTime;
    }
}
