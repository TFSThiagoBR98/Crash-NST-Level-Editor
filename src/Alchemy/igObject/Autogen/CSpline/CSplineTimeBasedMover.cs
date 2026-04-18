namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 4)]
    public class CSplineTimeBasedMover : CSplineVelocityMover
    {
        [FieldAttr(nst: 40, ctr: 36)] public float _time = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _easeInTime;
        [FieldAttr(nst: 48, ctr: 44)] public float _easeInVelocityScale = 0.5f;
        [FieldAttr(nst: 52, ctr: 48)] public float _easeOutTime;
        [FieldAttr(nst: 56, ctr: 52)] public float _easeOutVelocityScale = 0.5f;
        [FieldAttr(nst: 60, ctr: 56)] public float _elapsedTime;
        [FieldAttr(nst: 64, ctr: 60)] public bool _reversing;
    }
}
