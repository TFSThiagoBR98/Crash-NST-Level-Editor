namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class CDifficultySpecificFloat : CDifficultySpecificValue
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _easyValue;
        [FieldAttr(nst: 20, ctr: 16)] public float _mediumValue;
        [FieldAttr(nst: 24, ctr: 20)] public float _hardValue;
        [FieldAttr(nst: 28, ctr: 24)] public float _nightmareValue;
    }
}
