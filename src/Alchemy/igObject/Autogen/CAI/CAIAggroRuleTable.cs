namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CAIAggroRuleTable : igHashTable<string, igObject>
    {
        [FieldAttr(nst: 64)] public bool _isDirty;
        [FieldAttr(nst: 72)] public CAIAggroRuleList? _list;
    }
}
