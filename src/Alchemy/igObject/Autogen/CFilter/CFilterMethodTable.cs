namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CFilterMethodTable : igHashTable<string, CFilterMethod>
    {
        [FieldAttr(nst: 64, ctr: 60)] public bool _isDirty;
    }
}
