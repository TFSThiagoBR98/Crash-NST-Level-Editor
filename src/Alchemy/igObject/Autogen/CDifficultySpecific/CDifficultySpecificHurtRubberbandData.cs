namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificHurtRubberbandData : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CHurtRubberbandData? _easyValue;
        [FieldAttr(ctr: 24)] public CHurtRubberbandData? _mediumValue;
        [FieldAttr(ctr: 32)] public CHurtRubberbandData? _hardValue;
        [FieldAttr(ctr: 40)] public CHurtRubberbandData? _nightmareValue;
    }
}
