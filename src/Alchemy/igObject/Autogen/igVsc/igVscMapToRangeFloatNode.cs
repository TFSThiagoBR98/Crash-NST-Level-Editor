namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVscMapToRangeFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscFloatAccessor? _input;
        [FieldAttr(nst: 24, ctr: 24)] public igVscBoolAccessor? _clampInput;
        [FieldAttr(nst: 32, ctr: 32)] public igVscFloatAccessor? _inputLow;
        [FieldAttr(nst: 40, ctr: 40)] public igVscFloatAccessor? _inputHigh;
        [FieldAttr(nst: 48, ctr: 48)] public igVscFloatAccessor? _outputLow;
        [FieldAttr(nst: 56, ctr: 56)] public igVscFloatAccessor? _outputHigh;
        [FieldAttr(nst: 64, ctr: 64)] public igVscFloatAccessor? _output;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igVscActionNode? _out;
    }
}
