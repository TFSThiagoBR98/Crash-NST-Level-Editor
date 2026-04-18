namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CBehaviorActivatorNode : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igRawRefMetaField _havokStateMachine = new();
        [FieldAttr(nst: 32, ctr: 32)] public int _stateId = -1;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public CBehaviorActivatorNode? _parent;
    }
}
