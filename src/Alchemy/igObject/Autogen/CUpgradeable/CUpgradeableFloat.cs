namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CUpgradeableFloat : CUpgradeableValue
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _defaultValue;
        [FieldAttr(nst: 24, ctr: 16)] public CUpgradeableFloatTable? _upgradedValues;
    }
}
