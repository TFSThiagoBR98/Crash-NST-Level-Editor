namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8, meta: true)]
    public class igGuiVscBehavior : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiPlaceable? _owner;
        [FieldAttr(nst: 24, ctr: 24)] public igRawRefMetaField _dynamicFieldMemory = new();
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igMetaObject? _meta = (null);
    }
}
