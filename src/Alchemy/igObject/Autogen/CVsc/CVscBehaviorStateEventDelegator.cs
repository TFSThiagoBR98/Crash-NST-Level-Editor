namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CVscBehaviorStateEventDelegator : igVscDelegator
    {
        [FieldAttr(nst: 24)] public igVscObjectAccessor? _target;
    }
}
