namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CUpgradeableInt : CUpgradeableValue
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _defaultValue;
        [FieldAttr(nst: 24, ctr: 16)] public CUpgradeableIntTable? _upgradedValues;
    }
}
