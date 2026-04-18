namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscNegateFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _value;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _output;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
