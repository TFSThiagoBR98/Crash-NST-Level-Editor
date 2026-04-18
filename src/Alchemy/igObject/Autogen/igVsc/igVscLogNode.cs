namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscLogNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscStringAccessor? _channel;
        [FieldAttr(nst: 24, ctr: 24)] public igVscStringAccessor? _prefix;
        [FieldAttr(nst: 32, ctr: 32)] public igVscAccessor? _value;
        [FieldAttr(nst: 40, ctr: 40)] public igVscStringAccessor? _postfix;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _out;
    }
}
