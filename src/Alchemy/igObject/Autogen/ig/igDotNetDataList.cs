namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igDotNetDataList : igDataList
    {
        [FieldAttr(nst: 24)] public igMemoryRef<DotNetDataMetaField> _data = new();
    }
}
