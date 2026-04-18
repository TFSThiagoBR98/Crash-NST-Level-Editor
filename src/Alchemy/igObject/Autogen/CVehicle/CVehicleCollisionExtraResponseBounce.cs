namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CVehicleCollisionExtraResponseBounce : CVehicleCollisionExtraResponseReorientBase
    {
        [FieldAttr(nst: 64, ctr: 56)] public float _bounciness = 0.69999999f;
        [FieldAttr(nst: 68, ctr: 60)] public float _minSpeedRatioToReflection = 0.1f;
        [FieldAttr(nst: 72, ctr: 64)] public float _minBounceReflectionSpeedRatio = 0.1f;
        [FieldAttr(nst: 76, ctr: 68)] public float _maxBounceReflectionSpeedRatio = 0.5f;
    }
}
