namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscLogicalORNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscBoolAccessor? _a;
        [FieldAttr(nst: 24)] public igVscBoolAccessor? _b;
        [FieldAttr(nst: 32)] public igVscBoolAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
