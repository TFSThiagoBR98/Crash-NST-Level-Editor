namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CPowerShieldComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CGameEntity? _shieldData;
        [FieldAttr(ctr: 32)] public CGameEntity? _juicedShieldData;
    }
}
