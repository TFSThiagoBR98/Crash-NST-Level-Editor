namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CCEGraphEvent : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, refCount: false)] public CEntityMessage? _graphEvent;
    }
}
