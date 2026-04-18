namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CFilterByComponent : CFilterMethod
    {
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _componentType = new();
    }
}
