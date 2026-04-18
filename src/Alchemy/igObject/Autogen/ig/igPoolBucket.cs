namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igPoolBucket : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMemoryRef<u8> _data = new();
        [FieldAttr(nst: 32, ctr: 32)] public uint _count;
        [FieldAttr(nst: 40, ctr: 40)] public igPoolBucket? _next;
    }
}
