namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVscNegateBoolNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscBoolAccessor? _value;
        [FieldAttr(nst: 24, ctr: 24)] public igVscBoolAccessor? _output;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _out;
    }
}
