namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscDotVec3fAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _vectorA;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _vectorB;
    }
}
