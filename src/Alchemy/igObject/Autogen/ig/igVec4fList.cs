namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVec4fList : igDataList
    {
        [FieldAttr(ctr: 24)] public igMemoryRef<igVec4fMetaField> _data = new();
    }
}
