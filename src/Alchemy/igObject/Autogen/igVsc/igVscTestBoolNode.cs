namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVscTestBoolNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscBoolAccessor? _inputBool;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igVscActionNode? _boolTrue;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _boolFalse;
    }
}
