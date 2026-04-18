namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8, meta: true)]
    public class igVscMacro : igObject
    {
        [FieldAttr(nst: 16)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 24, refCount: false)] public igMetaObject? _meta = (null);
    }
}
