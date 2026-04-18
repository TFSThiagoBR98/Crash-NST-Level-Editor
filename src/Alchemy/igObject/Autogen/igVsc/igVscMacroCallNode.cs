namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8, meta: true)]
    public class igVscMacroCallNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igVscActionNode? _instancedNode;
        [FieldAttr(nst: 24, ctr: 24)] public igObjectList? _instancedNodes;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _out;
        [FieldAttr(nst: 40, ctr: 40)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igMetaObject? _meta = (null);
    }
}
