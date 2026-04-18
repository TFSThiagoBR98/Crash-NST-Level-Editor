namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVscModulusNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscFloatAccessor? _input;
        [FieldAttr(nst: 24, ctr: 24)] public igVscFloatAccessor? _modulus;
        [FieldAttr(nst: 32, ctr: 32)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _out;
    }
}
