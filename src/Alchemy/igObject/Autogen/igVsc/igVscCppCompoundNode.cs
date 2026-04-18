namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscCppCompoundNode : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igVscAccessor> _accessors = new();
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _out;
        [FieldAttr(nst: 48, ctr: 48)] public igVscActionNodeList? _outNodes;
    }
}
