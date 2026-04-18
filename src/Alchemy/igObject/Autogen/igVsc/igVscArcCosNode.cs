namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscArcCosNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _cosine;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _angle;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
