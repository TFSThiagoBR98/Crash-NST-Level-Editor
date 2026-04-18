namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CSplineEvent : igSplineEvent
    {
        [FieldAttr(nst: 32, ctr: 24)] public CSplineEventDelegate? _onSplineEvent;
        [FieldAttr(nst: 40, ctr: 32)] public CSplineEventDelegateEventList? _onSplineEventList;
    }
}
