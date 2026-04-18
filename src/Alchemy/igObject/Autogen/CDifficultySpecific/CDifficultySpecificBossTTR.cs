namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CDifficultySpecificBossTTR : CDifficultySpecificValue
    {
        [FieldAttr(ctr: 16)] public CBossLapTTRData? _easyValue;
        [FieldAttr(ctr: 24)] public CBossLapTTRData? _mediumValue;
        [FieldAttr(ctr: 32)] public CBossLapTTRData? _hardValue;
        [FieldAttr(ctr: 40)] public CBossLapTTRData? _nightmareValue;
    }
}
