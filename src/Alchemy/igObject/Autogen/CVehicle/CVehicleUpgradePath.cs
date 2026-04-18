namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CVehicleUpgradePath : igNamedObject
    {
        [FieldAttr(nst: 24)] public CVehicleUpgradeList? _upgrades;
    }
}
