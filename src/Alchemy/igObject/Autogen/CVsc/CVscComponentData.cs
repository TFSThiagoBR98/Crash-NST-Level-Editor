namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8, meta: true)]
    public class CVscComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 32, ctr: 24, refCount: false)] public igMetaObject? _meta;
    }
}
