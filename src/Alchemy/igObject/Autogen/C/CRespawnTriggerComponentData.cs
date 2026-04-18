namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CRespawnTriggerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CQueryFilter? _queryFilter;
        [FieldAttr(ctr: 24)] public ERespawnType _respawnType;
        [FieldAttr(ctr: 32)] public CPlayerStartEntityHandleList? _respawnPoints;
    }
}
