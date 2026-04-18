namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CCustomEventEntity : CCustomEvent
    {
        [FieldAttr(nst: 64)] public igHandleMetaField _entity = new();
    }
}
