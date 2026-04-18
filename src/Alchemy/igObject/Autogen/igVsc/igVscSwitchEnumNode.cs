namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVscSwitchEnumNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscEnumAccessor? _choice;
        [FieldAttr(nst: 24, ctr: 24)] public igEnumVscActionNodeHashTable? _outputs;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igVscActionNode? _outOfRange;
    }
}
