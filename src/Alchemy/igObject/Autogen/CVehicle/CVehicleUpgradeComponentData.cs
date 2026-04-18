namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVehicleUpgradeComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleUpgradePath? _shieldUpgrades;
        [FieldAttr(nst: 32)] public CVehicleUpgradePath? _weaponUpgrades;
    }
}
