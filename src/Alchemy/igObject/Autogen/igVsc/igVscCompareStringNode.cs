namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscCompareStringNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscStringAccessor? _a;
        [FieldAttr(nst: 24, ctr: 24)] public igVscStringAccessor? _b;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _equalTo;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _notEqualTo;
        [FieldAttr(nst: 48, ctr: 48)] public igVscBoolAccessor? _ignoreCase;
    }
}
