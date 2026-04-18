namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class igVscMultipleStringAccessor : igVscStringAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVectorMetaField<igVscAccessor> _accessors = new();
    }
}
