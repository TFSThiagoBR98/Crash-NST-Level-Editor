namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscAbsFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _input;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _absoluteValue;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
