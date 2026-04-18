namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class CDifficultySpecificInt : CDifficultySpecificValue
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _easyValue;
        [FieldAttr(nst: 20, ctr: 16)] public int _mediumValue;
        [FieldAttr(nst: 24, ctr: 20)] public int _hardValue;
        [FieldAttr(nst: 28, ctr: 24)] public int _nightmareValue;
    }
}
