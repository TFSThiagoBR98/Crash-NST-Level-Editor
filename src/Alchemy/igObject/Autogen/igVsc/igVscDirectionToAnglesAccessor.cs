namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscDirectionToAnglesAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _vector;
        [FieldAttr(nst: 32)] public igVscBoolAccessor? _normalize;
    }
}
