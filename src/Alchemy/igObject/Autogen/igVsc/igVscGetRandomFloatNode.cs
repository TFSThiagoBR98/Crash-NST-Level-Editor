namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscGetRandomFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igVscFloatAccessor? _min;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igVscFloatAccessor? _max;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscObjectAccessor? _randomGenerator;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _out;
    }
}
