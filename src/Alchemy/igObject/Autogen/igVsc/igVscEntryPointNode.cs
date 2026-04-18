namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscEntryPointNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscAccessorList? _accessors;
        [FieldAttr(nst: 24, ctr: 24)] public igVscAccessorList? _filters;
        [FieldAttr(nst: 32, ctr: 32)] public igVscIntAccessor? _timesFired;
        [FieldAttr(nst: 40, ctr: 40)] public igVscIntAccessor? _timesToFire;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _node;
    }
}
