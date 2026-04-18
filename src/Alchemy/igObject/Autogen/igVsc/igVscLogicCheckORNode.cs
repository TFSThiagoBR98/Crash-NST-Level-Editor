namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class igVscLogicCheckORNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscBoolAccessor? _a;
        [FieldAttr(nst: 24)] public igVscBoolAccessor? _b;
        [FieldAttr(nst: 32)] public igVscBoolAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _resultTrue;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _resultFalse;
        [FieldAttr(nst: 56, refCount: false)] public igVscActionNode? _out;
    }
}
