namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVscBehaviorStateEventOnEnterDelegator : CVscBehaviorStateEventDelegator
    {
        [FieldAttr(nst: 32)] public igVscObjectAccessor? _state;
    }
}
