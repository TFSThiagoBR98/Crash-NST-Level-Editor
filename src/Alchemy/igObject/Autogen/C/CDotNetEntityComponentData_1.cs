namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8, meta: true)]
    public class CDotNetEntityComponentData_1 : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 32, refCount: false)] public igMetaObject? _meta;
    }
}
