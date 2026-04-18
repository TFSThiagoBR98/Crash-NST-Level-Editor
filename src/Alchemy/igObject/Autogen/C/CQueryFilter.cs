namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CQueryFilter : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _typesToInclude;
        [FieldAttr(nst: 24, ctr: 16)] public CFilterEntities? _filterMethods;
        [FieldAttr(nst: 32, ctr: 24)] public EQuerySortMode _sortMode;
        [FieldAttr(nst: 40, ctr: 32)] public CQueryFilter? _queryToAppend;
        [FieldAttr(nst: 48, ctr: 40)] public bool _onlyConsiderEnabled = true;
    }
}
