namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class CMaintainTargetHeadingController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public CStackBlender.EBlendType _yawBlendType;
        [FieldAttr(nst: 60, ctr: 56)] public bool _alwaysFaceForward;
        [FieldAttr(nst: 64, ctr: 60)] public float _yawDampingMin = 0.05f;
        [FieldAttr(nst: 68, ctr: 64)] public float _yawDampingMid = 0.08f;
        [FieldAttr(nst: 72, ctr: 68)] public float _yawDampingMax = 0.03f;
        [FieldAttr(nst: 76, ctr: 72)] public float _yawDampingInAir = 0.01f;
        [FieldAttr(nst: 80, ctr: 76)] public float _yawDampingForcedReorient = 0.1f;
        [FieldAttr(nst: 84, ctr: 80)] public float _angleToStartMaintainHeading = 10.0f;
        [FieldAttr(nst: 88, ctr: 84)] public float _angleToDivideMaintainHeading = 90.0f;
        [FieldAttr(nst: 92, ctr: 88)] public float _angleToEndMaintainHeading = 150.0f;
        [FieldAttr(nst: 96, ctr: 92)] public float _durationRunningBeforeMaintainHeading = 0.1f;
        [FieldAttr(nst: 100, ctr: 96)] public bool _headingBasedOnVelocity;
    }
}
