namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CBehaviorStateMachine : CBehaviorActivatorNode
    {
        [FieldAttr(nst: 48, ctr: 48)] public CBehaviorStateList? _states;
    }
}
