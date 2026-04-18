namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CAEEvent : igObject
    {
        [FieldAttr(ctr: 12)] public uint _id;
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public u64 _timestamp;
        [FieldAttr(ctr: 32)] public igStringUnsignedIntHashTable? _additionalKvp;
    }
}
