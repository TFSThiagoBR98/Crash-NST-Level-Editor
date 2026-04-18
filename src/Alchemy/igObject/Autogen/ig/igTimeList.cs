namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igTimeList : igDataList
    {
        [FieldAttr(ctr: 24)] public igMemoryRef<igTimeMetaField> _data = new();
    }
}
