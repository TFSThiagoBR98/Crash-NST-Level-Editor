namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificHurtRubberbandDataTable : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CHurtRubberbandDataTable? _easyValue;
        [FieldAttr(ctr: 24)] public CHurtRubberbandDataTable? _mediumValue;
        [FieldAttr(ctr: 32)] public CHurtRubberbandDataTable? _hardValue;
        [FieldAttr(ctr: 40)] public CHurtRubberbandDataTable? _nightmareValue;
    }
}
