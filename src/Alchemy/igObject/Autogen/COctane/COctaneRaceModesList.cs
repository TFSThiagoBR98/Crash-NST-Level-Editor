namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class COctaneRaceModesList : igDataList
    {
        [FieldAttr(ctr: 24)] public igMemoryRef<igEnumMetaField> _data = new();
    }
}
