namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVscBehaviorStateEventOnEnterByNameDelegator : CVscBehaviorStateEventDelegator
    {
        [FieldAttr(nst: 32)] public igVscStringAccessor? _stateName;
    }
}
