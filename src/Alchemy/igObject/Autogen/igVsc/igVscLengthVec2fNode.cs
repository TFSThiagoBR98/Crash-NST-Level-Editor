namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscLengthVec2fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec2fAccessor? _vector;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
