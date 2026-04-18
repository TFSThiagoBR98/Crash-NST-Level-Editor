namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 80, align: 8)]
    public class CCEAttackSpawn : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public CProjectileSpawnData? _spawnData;
        [FieldAttr(nst: 88, ctr: 72)] public CPhysicalEntityData? _entityData;
    }
}
