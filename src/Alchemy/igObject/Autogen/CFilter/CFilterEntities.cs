namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CFilterEntities : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CFilterMethodList? _filterMethods;
        [FieldAttr(nst: 24, ctr: 24)] public CFilterMethodTable? _filterMethodTable;
    }
}
