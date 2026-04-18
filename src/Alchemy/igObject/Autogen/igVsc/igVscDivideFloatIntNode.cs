namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscDivideFloatIntNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _a;
        [FieldAttr(nst: 24)] public igVscIntAccessor? _b;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _return;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
