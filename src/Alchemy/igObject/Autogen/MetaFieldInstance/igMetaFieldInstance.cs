namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class igMetaFieldInstance : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public u16 _parentMetaObjectIndex = 65535;
        [FieldAttr(nst: 18, ctr: 14)] public i16 _typeIndex = -1;
        [FieldAttr(nst: 20, ctr: 16)] public i16 _internalIndex = -1;
        [FieldAttr(nst: 22, ctr: 18)] public u16 _size;
        [FieldAttr(nst: 24, ctr: 20)] public u16 _offset;
        [FieldAttr(nst: 32, ctr: 24)] public igObject? _attributes;
        [FieldAttr(nst: 40, ctr: 32)] public uint _properties;
        [FieldAttr(nst: 48, ctr: 40)] public string? _fieldName = null;
    }
}
