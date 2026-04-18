namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CSplineGraphEvent : igSplineEvent
    {
        [FieldAttr(nst: 32)] public CEntityMessage? _graphEvent;
    }
}
