namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CLevelBorder : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CLevelBorderWaypointListList? _borderPoints;
        [FieldAttr(nst: 24, ctr: 24)] public float _topOffset = 150.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _bottomOffset = 50.0f;
        [FieldAttr(nst: 32, ctr: 32)] public bool _reverseDirection;
    }
}
