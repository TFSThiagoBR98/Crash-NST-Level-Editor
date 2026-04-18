namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificPowerUpWeightListData : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CPowerUpWeightRefList? _easyValue;
        [FieldAttr(ctr: 24)] public CPowerUpWeightRefList? _mediumValue;
        [FieldAttr(ctr: 32)] public CPowerUpWeightRefList? _hardValue;
        [FieldAttr(ctr: 40)] public CPowerUpWeightRefList? _nightmareValue;
    }
}
