namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CExplosiveCrateComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CGameEntity? _tntCrateInfo;
        [FieldAttr(ctr: 32)] public CGameEntity? _nitroCrateInfo;
        [FieldAttr(ctr: 40)] public igVec3fMetaField _spawnOffset = new();
    }
}
