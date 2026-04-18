namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscMultiplyScalarVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _a;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _b;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _return;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
