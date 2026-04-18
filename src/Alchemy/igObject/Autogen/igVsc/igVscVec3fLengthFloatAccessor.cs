namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igVscVec3fLengthFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _object;
    }
}
