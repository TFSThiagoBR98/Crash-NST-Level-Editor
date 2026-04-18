namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CVehicleStatsComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleStats? _baseStats;
    }
}
