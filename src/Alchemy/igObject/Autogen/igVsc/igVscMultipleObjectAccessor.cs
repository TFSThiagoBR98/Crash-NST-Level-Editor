namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVscMultipleObjectAccessor : igVscObjectAccessor
    {
        [FieldAttr(ctr: 16)] public igVectorMetaField<igVscAccessor> _accessors = new();
    }
}
