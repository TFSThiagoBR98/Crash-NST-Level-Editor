namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igVscOnVariableChangedDelegator : igVscDelegator
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVscAccessor? _target;
    }
}
