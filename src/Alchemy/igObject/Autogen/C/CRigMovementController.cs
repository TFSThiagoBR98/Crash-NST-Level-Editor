namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CRigMovementController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _dampingXY = 0.15f;
        [FieldAttr(nst: 60, ctr: 56)] public float _dampingZ = 1.0f;
        [FieldAttr(nst: 64, ctr: 60)] public bool _applyLookAhead;
        [FieldAttr(nst: 68, ctr: 64)] public float _dampingLookAhead = 0.15f;
        [FieldAttr(nst: 72, ctr: 68)] public float _dampingLookAheadReturn = 0.03f;
        [FieldAttr(nst: 76, ctr: 72)] public float _lookAheadDistance = 200.0f;
        [FieldAttr(nst: 80, ctr: 76)] public CStackBlender.EBlendType _yawBlendType;
        [FieldAttr(nst: 84, ctr: 80)] public bool _debugDrawTargetInfo = true;
    }
}
