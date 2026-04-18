namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igVscNegateVec3fAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _value;
    }
}
