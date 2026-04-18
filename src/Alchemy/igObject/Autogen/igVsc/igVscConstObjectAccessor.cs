namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscConstObjectAccessor : igVscObjectAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _value = new();
    }
}
