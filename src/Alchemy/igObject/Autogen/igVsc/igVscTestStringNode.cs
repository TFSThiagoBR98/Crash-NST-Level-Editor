namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVscTestStringNode : igVscActionNode
    {
        [FieldAttr(ctr: 16)] public igVscStringAccessor? _inputString;
        [FieldAttr(ctr: 24, refCount: false)] public igVscActionNode? _boolNotEmpty;
        [FieldAttr(ctr: 32, refCount: false)] public igVscActionNode? _boolEmpty;
    }
}
