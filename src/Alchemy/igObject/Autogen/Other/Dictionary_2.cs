namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8, meta: true)]
    public class Dictionary_2 : igDotNetDataDataHashTable
    {
        [FieldAttr(nst: 64)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 72, refCount: false)] public igMetaObject? _meta;
    }
}
