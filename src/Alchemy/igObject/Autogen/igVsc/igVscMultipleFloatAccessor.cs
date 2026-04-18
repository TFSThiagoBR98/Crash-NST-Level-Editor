namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscMultipleFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVectorMetaField<igVscAccessor> _accessors = new();
    }
}
