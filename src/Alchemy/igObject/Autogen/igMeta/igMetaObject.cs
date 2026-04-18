namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 152, align: 8)]
    public class igMetaObject : igBaseMeta
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVectorMetaField<igMetaFieldInstance> _metaFields = new();
        [FieldAttr(nst: 48, ctr: 48)] public int _instanceCount;
        [FieldAttr(nst: 56, ctr: 56)] public igRawRefMetaField _vTablePointer = new();
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igMetaObject? _parent;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igMetaObject? _lastChild;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igMetaObject? _nextSibling;
        [FieldAttr(nst: 88, ctr: 88)] public u16 _index = 65535;
        [FieldAttr(nst: 90, ctr: 90)] public u16 _sizeofSize = 65535;
        [FieldAttr(nst: 92, ctr: 92)] public u16 _properties;
        [FieldAttr(nst: 94, ctr: 94)] public u16 _requiredAlignment = 4;
        [FieldAttr(nst: 96, ctr: 96)] public u16 _dynamicFieldSize;
        [FieldAttr(nst: 98, ctr: 98)] public u16 _requiredDynamicFieldAlignment = 4;
        [FieldAttr(nst: 104, ctr: 104)] public igVectorMetaField<igMetaFunction> _metaFunctions = new();
        [FieldAttr(nst: 128, ctr: 128)] public igObject? _attributes;
        [FieldAttr(nst: 136, ctr: 136, refCount: false)] public igObject? _library;
        [FieldAttr(nst: 144, ctr: 144)] public int _id = -1;
    }
}
