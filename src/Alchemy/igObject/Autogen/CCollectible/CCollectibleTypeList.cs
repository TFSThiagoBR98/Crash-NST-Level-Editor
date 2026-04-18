namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CCollectibleTypeList : igDataList
    {
        [FieldAttr(ctr: 24)] public igMemoryRef<igEnumMetaField> _data = new();
    }
}
