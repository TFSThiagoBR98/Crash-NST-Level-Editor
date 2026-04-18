namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CUpgradeableVfx : CUpgradeableValue
    {
        [FieldAttr(nst: 16, ctr: 16)] public CUpgradeableVfxData? _defaultValue;
        [FieldAttr(nst: 24, ctr: 24)] public CUpgradeableVfxTable? _upgradedValues;
    }
}
