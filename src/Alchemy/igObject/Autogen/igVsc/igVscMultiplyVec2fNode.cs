namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscMultiplyVec2fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec2fAccessor? _a;
        [FieldAttr(nst: 24)] public igVscVec2fAccessor? _b;
        [FieldAttr(nst: 32)] public igVscVec2fAccessor? _return;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
