namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igVscCppActionNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igVscAccessor> _accessors = new();
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _out;
        [FieldAttr(nst: 48, ctr: 48)] public igVscActionNodeList? _outNodes;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igMetaFunction? _metaFunction;
    }
}
