namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class igVscIsIntEqualToIntNode : igVscActionNode
    {
        [FieldAttr(ctr: 16)] public igVscIntAccessor? _a;
        [FieldAttr(ctr: 24)] public igVscIntAccessor? _b;
        [FieldAttr(ctr: 32)] public igVscBoolAccessor? _result;
        [FieldAttr(ctr: 40, refCount: false)] public igVscActionNode? _out;
    }
}
