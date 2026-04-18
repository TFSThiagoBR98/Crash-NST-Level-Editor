namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class igVscAxisToRotationNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _forward;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _left;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _up;
        [FieldAttr(nst: 40)] public igVscIntAccessor? _primaryAxis;
        [FieldAttr(nst: 48)] public igVscIntAccessor? _secondaryAxis;
        [FieldAttr(nst: 56)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 64, refCount: false)] public igVscActionNode? _out;
    }
}
