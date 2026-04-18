namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CSplineLooseConstantVelocityMover : CSplineVelocityMover
    {
        [FieldAttr(nst: 40)] public float _velocity = 100.0f;
        [FieldAttr(nst: 44)] public float _tolerance;
        [FieldAttr(nst: 48, refCount: false)] public CEntity? _entityOnSpline;
    }
}
