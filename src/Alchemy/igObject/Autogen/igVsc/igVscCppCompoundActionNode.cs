namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igVscCppCompoundActionNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscPlaceable? _compoundNode;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igMetaFunction? _metaFunction;
    }
}
