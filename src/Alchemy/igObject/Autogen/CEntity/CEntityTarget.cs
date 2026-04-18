namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8, meta: true)]
    public class CEntityTarget : Object
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _targetEntity = new();
    }
}
