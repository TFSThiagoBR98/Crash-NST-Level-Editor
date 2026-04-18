namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igShaderHeader : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMemoryRef<u8> _data = new();
    }
}
