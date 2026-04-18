namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CMoveToOffsetController : CBaseMovementController
    {
        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _targetOffset = new();
        [FieldAttr(nst: 68, ctr: 60)] public EigEaseType _easeType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 72, ctr: 64)] public float _totalDuration;
        [FieldAttr(nst: 76, ctr: 68)] public float _easeInDuration;
        [FieldAttr(nst: 80, ctr: 72)] public float _easeOutDuration;
        [FieldAttr(nst: 84, ctr: 76)] public float _currentDuration;
    }
}
