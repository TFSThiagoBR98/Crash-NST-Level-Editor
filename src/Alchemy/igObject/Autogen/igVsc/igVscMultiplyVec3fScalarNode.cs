namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscMultiplyVec3fScalarNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _a;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _b;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _return;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
