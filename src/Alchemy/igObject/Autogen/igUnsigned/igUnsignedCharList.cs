namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igUnsignedCharList : igDataList
    {
        [FieldAttr(nst: 24, ctr: 24)] public igMemoryRef<u8> _data = new();
    }
}
