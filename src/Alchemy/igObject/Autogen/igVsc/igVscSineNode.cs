namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscSineNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _angle;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _sine;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
