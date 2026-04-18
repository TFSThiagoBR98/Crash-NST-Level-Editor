namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscMultiplyIntNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscIntAccessor? _a;
        [FieldAttr(nst: 24)] public igVscIntAccessor? _b;
        [FieldAttr(nst: 32)] public igVscIntAccessor? _return;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
