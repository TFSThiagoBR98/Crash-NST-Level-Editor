namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, meta: true)]
    public class CVscComponent : CEntityComponent
    {
        [FieldAttr(nst: 48)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 56, refCount: false)] public igMetaObject? _meta;
    }
}
