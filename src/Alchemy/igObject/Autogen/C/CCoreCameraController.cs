namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 136, align: 8)]
    public class CCoreCameraController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _targetDistance = 450.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _distanceDamping = 0.07f;
        [FieldAttr(nst: 64, ctr: 60)] public CStackBlender.EBlendType _distanceBlendType;
        [FieldAttr(nst: 68, ctr: 64)] public float _yawDamping = 0.05f;
        [FieldAttr(nst: 72, ctr: 68)] public CStackBlender.EBlendType _yawBlendType;
        [FieldAttr(nst: 76, ctr: 72)] public bool _applyTargetPitch;
        [FieldAttr(nst: 80, ctr: 76)] public float _targetPitch = 15.0f;
        [FieldAttr(nst: 84, ctr: 80)] public float _pitchDamping = 0.04f;
        [FieldAttr(nst: 88, ctr: 84)] public CStackBlender.EBlendType _pitchBlendType;
        [FieldAttr(nst: 92, ctr: 88)] public float _targetRoll;
        [FieldAttr(nst: 96, ctr: 92)] public float _rollDamping = 0.1f;
        [FieldAttr(nst: 100, ctr: 96)] public CStackBlender.EBlendType _rollBlendType;
        [FieldAttr(nst: 104, ctr: 100)] public float _targetFov = 80.0f;
        [FieldAttr(nst: 108, ctr: 104)] public float _fovDamping = 0.1f;
        [FieldAttr(nst: 112, ctr: 108)] public CStackBlender.EBlendType _fovBlendType;
        [FieldAttr(nst: 116, ctr: 112)] public float _targetHorizontalOffset;
        [FieldAttr(nst: 120, ctr: 116)] public float _horizontalOffsetDamping = 0.3f;
        [FieldAttr(nst: 124, ctr: 120)] public CStackBlender.EBlendType _horizontalOffsetBlendType;
        [FieldAttr(nst: 128, ctr: 124)] public float _targetVerticalOffset = 100.0f;
        [FieldAttr(nst: 132, ctr: 128)] public float _verticalOffsetDamping = 0.05f;
        [FieldAttr(nst: 136, ctr: 132)] public CStackBlender.EBlendType _verticalOffsetBlendType;
    }
}
