namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscGetRandomVec3fRangedNode : igVscActionNode
    {
        [FieldAttr(nst: 16, refCount: false)] public igVscVec3fAccessor? _minVec;
        [FieldAttr(nst: 24, refCount: false)] public igVscVec3fAccessor? _maxVec;
        [FieldAttr(nst: 32, refCount: false)] public igVscObjectAccessor? _randomGenerator;
        [FieldAttr(nst: 40, refCount: false)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
