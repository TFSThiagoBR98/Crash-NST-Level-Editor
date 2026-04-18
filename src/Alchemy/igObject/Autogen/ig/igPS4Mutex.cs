namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igPS4Mutex : igBaseMutex
    {
        [FieldAttr(ctr: 32)] public igRawRefMetaField _mutex = new();
    }
}
