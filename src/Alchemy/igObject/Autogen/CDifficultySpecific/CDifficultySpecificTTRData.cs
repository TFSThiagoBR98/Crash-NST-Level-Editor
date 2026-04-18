namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificTTRData : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CTTRData? _easyValue;
        [FieldAttr(ctr: 24)] public CTTRData? _mediumValue;
        [FieldAttr(ctr: 32)] public CTTRData? _hardValue;
        [FieldAttr(ctr: 40)] public CTTRData? _nightmareValue;
    }
}
