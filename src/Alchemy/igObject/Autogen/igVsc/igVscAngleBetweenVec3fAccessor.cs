namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igVscAngleBetweenVec3fAccessor : igVscFloatAccessor
    {
        [FieldAttr(ctr: 16)] public igVscVec3fAccessor? _vectorA;
        [FieldAttr(ctr: 24)] public igVscVec3fAccessor? _vectorB;
    }
}
