namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igLocalizedHashTable : igUnsignedIntStringHashTable
    {
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _object = new();
        [FieldAttr(nst: 72, ctr: 72)] public igObject? _field;
    }
}
