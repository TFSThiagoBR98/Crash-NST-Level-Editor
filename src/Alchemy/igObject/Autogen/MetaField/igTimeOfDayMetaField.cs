namespace Alchemy
{
    [ObjectAttr(28, 8)]
    public class igTimeOfDayMetaField : igMetaField
    {
        [FieldAttr(0)] public i32 _year;
        [FieldAttr(4)] public i32 _month;
        [FieldAttr(8)] public i32 _day;
        [FieldAttr(12)] public i32 _hour;
        [FieldAttr(16)] public i32 _minute;
        [FieldAttr(20)] public i32 _second;
        [FieldAttr(24)] public i32 _weekDay;
    }
}
