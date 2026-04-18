namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8, meta: true)]
    public class Delegate : Object
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVectorMetaField<DelegateFunctionMetaField> _invocationList = new();
    }
}
