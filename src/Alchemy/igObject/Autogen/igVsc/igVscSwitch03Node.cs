namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscSwitch03Node : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscIntAccessor? _choice;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igVscActionNode? _output0;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _output1;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _output2;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _outOfRange;
    }
}
