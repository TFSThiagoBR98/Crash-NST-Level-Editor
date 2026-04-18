namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscGetRandomVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16, refCount: false)] public igVscObjectAccessor? _randomGenerator;
        [FieldAttr(nst: 24, refCount: false)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
