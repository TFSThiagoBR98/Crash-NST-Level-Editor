namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificPowerUpWeightHashTable : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CPowerUpWeightHashTable? _easyValue;
        [FieldAttr(ctr: 24)] public CPowerUpWeightHashTable? _mediumValue;
        [FieldAttr(ctr: 32)] public CPowerUpWeightHashTable? _hardValue;
        [FieldAttr(ctr: 40)] public CPowerUpWeightHashTable? _nightmareValue;
    }
}
