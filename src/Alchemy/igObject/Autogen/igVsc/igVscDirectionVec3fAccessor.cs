namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVscDirectionVec3fAccessor : igVscVec3fAccessor
    {
        [FieldAttr(ctr: 16)] public igVscVec3fAccessor? _fromPosition;
        [FieldAttr(ctr: 24)] public igVscVec3fAccessor? _toPosition;
        [FieldAttr(ctr: 32)] public igVscBoolAccessor? _normalize;
    }
}
