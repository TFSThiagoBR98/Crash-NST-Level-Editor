namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class igDataBindingEntity : igObject
    {
        [FieldAttr(ctr: 16)] public igObject? _object;
        [FieldAttr(ctr: 24)] public igHandleMetaField _objectHandle = new();
        [FieldAttr(ctr: 32)] public igMetaFieldInstance? _field;
        [FieldAttr(ctr: 40)] public string? _fieldName;
        [FieldAttr(ctr: 48)] public uint _constant;
        [FieldAttr(ctr: 80)] public igDataTransform? _transform;
    }
}
