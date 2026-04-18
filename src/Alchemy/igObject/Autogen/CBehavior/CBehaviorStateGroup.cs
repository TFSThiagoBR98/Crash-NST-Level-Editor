namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CBehaviorStateGroup : igObject
    {
        [FieldAttr(nst: 16)] public CBehaviorActivatorNodeHandleList? _activatorStates;
        [FieldAttr(nst: 24)] public CBehaviorActivatorNodeHandleList? _deactivatorStates;
    }
}
