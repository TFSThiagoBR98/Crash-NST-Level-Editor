namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 72, align: 8)]
    public class CCECustomEvent : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public CCustomEvent? _customEvent;
    }
}
