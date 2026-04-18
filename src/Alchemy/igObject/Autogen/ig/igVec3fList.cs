namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVec3fList : igDataList
    {
        [FieldAttr(nst: 24, ctr: 24)] public igMemoryRef<igVec3fMetaField> _data = new();
    }
}
