namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8, meta: true)]
    public class igDynamicObject : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igMetaObject? _meta = (null);
    }
}
