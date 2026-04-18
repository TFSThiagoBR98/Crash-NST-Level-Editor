namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 4)]
    public class CSplineVelocityMover : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _convergeRatio;
        [FieldAttr(nst: 20, ctr: 16)] public bool _convergeCompleted;
        [FieldAttr(nst: 24, ctr: 20)] public float _startVelocity;
        [FieldAttr(nst: 28, ctr: 24)] public float _currentBaseVelocity;
        [FieldAttr(nst: 32, ctr: 28)] public float _linearMultiplier = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _linearAddition;
    }
}
