namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class igCompoundMetaFieldInstance : igMetaFieldInstance
    {
        [FieldAttr(nst: 56, refCount: false)] public igMemoryRef<igCompoundMetaField> _default = new();
        [FieldAttr(nst: 72)] public igMetaFieldList? _fieldList;
    }
}
