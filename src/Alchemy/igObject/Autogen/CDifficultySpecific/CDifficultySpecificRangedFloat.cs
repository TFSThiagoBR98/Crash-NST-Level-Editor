namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CDifficultySpecificRangedFloat : CDifficultySpecificValue
    {
        [FieldAttr(nst: 16, ctr: 12)] public igRangedFloatMetaField _easyValue = new();
        [FieldAttr(nst: 24, ctr: 20)] public igRangedFloatMetaField _mediumValue = new();
        [FieldAttr(nst: 32, ctr: 28)] public igRangedFloatMetaField _hardValue = new();
        [FieldAttr(nst: 40, ctr: 36)] public igRangedFloatMetaField _nightmareValue = new();
    }
}
