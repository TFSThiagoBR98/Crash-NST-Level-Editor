namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igNonRefCountedObjectList : igDataList
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igMemoryRef<igRawRefMetaField> _data = new();
    }
}
