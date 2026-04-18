namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class igMetaEnum : igBaseMeta
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _flags;
        [FieldAttr(nst: 32, ctr: 32)] public igVectorMetaField<string> _names = new();
        [FieldAttr(nst: 56, ctr: 56)] public igVectorMetaField<int> _values = new();
        [FieldAttr(nst: 80, ctr: 80)] public igObject? _attributes;
        [FieldAttr(nst: 88, ctr: 88)] public igObject? _valueAttributes;
        [FieldAttr(nst: 96, ctr: 96)] public string? _declaringType = null;
    }
}
