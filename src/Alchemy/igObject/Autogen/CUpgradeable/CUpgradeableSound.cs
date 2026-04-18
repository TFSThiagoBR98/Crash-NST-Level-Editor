namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CUpgradeableSound : CUpgradeableValue
    {
        [FieldAttr(nst: 16, ctr: 16)] public CSoundDotNetHandle? _defaultValue;
        [FieldAttr(nst: 24, ctr: 24)] public CUpgradeableSoundTable? _upgradedValues;
    }
}
