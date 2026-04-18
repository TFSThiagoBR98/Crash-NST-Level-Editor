namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igIndexPool : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMemoryRef<uint> _data = new();
        [FieldAttr(nst: 32, ctr: 32)] public uint _allocatedCount;
    }
}
