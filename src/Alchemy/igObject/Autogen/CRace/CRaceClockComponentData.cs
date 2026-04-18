namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRaceClockComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _isDebugDisplay;
        [FieldAttr(ctr: 24)] public CRaceClockData? _raceClockData;
    }
}
