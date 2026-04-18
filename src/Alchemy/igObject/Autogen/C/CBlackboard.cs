namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CBlackboard : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CBlackboardInfoTable? _blackboardInfoTable;
        [FieldAttr(nst: 24, ctr: 24)] public CBlackboardInfoUpdaterList? _blackboardInfoUpdaterList;
    }
}
