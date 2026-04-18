namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igShortList : igDataList
    {
        [FieldAttr(ctr: 24)] public igMemoryRef<i16> _data = new();
    }
}
