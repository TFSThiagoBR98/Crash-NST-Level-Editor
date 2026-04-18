namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVscCompareObjectNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscAccessor? _a;
        [FieldAttr(nst: 24, ctr: 24)] public igVscAccessor? _b;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _same;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _different;
    }
}
