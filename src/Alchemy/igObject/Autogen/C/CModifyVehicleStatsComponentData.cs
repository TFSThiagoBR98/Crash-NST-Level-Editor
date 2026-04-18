namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CModifyVehicleStatsComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleStats? _stats;
        [FieldAttr(nst: 32)] public EVehicleStatSource _source = EVehicleStatSource.eVSS_TemporaryBoost;
    }
}
