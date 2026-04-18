namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igDataTransform : igObject
    {
        [FieldAttr(ctr: 16)] public igMetaFieldInstance? _destinationType;
        [FieldAttr(ctr: 24)] public igMetaFieldInstance? _sourceType;
    }
}
