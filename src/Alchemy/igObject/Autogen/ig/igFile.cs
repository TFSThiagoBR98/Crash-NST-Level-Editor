namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igFile : igObject
    {
        [FieldAttr(ctr: 16)] public igRawRefMetaField _file = new();
        [FieldAttr(ctr: 24)] public i64 _offset;
        [FieldAttr(ctr: 32)] public EPriority _priority;
    }
}
