namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVscAbsIntNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscIntAccessor? _input;
        [FieldAttr(nst: 24, ctr: 24)] public igVscIntAccessor? _absoluteValue;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _out;
    }
}
