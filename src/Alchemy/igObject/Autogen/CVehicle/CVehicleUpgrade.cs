namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVehicleUpgrade : CUpgrade
    {
        [FieldAttr(nst: 24)] public string? _upgradeName = null;
        [FieldAttr(nst: 32)] public int _cost;
        [FieldAttr(nst: 36)] public int _toyUpgradeFlagBit = -1;
    }
}
