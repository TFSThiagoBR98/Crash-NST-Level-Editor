namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CSplineComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igSpline2? _spline;
        [FieldAttr(nst: 32, ctr: 24)] public igSpline? _deprecatedSpline;
    }
}
