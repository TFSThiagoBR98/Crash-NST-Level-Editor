namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVscCompareFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscFloatAccessor? _a;
        [FieldAttr(nst: 24, ctr: 24)] public igVscFloatAccessor? _b;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _greaterThan;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _greaterThanOrEqualTo;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _equalTo;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igVscActionNode? _notEqualTo;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igVscActionNode? _lessThanOrEqualTo;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igVscActionNode? _lessThan;
    }
}
