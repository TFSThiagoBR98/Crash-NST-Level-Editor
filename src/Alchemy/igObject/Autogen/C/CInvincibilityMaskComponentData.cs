namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CInvincibilityMaskComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CGameEntity? _spawnedMaskData;
        [FieldAttr(ctr: 32)] public CGameEntity? _spawnedJuicedMaskData;
    }
}
