namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class CManualCameraController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public CStackBlender.EBlendType _horizontalRotationBlendType;
        [FieldAttr(nst: 60, ctr: 56)] public CStackBlender.EBlendType _verticalRotationBlendType;
        [FieldAttr(nst: 64, ctr: 60)] public bool _affectPitch = true;
        [FieldAttr(nst: 65, ctr: 61)] public bool _affectYaw = true;
        [FieldAttr(nst: 68, ctr: 64)] public float _horizontalRotationSpeed = 25.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _horizontalRotationDamping = 0.1f;
        [FieldAttr(nst: 76, ctr: 72)] public float _verticalRotationSpeed = 20.0f;
        [FieldAttr(nst: 80, ctr: 76)] public float _verticalRotationDamping = 0.08f;
        [FieldAttr(nst: 84, ctr: 80)] public float _verticalMinRange = -10.0f;
        [FieldAttr(nst: 88, ctr: 84)] public float _verticalMaxRange = 40.0f;
        [FieldAttr(nst: 92, ctr: 88)] public float _runningDurationToMaintainManualViewPitch = 1.0f;
        [FieldAttr(nst: 96, ctr: 92)] public float _runningDurationToMaintainManualViewYaw = 1.0f;
        [FieldAttr(nst: 100, ctr: 96)] public bool _debugDrawSticks = true;
    }
}
