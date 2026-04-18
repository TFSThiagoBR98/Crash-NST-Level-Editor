namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class COcclusionController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _yawDamping = 0.05f;
        [FieldAttr(nst: 60, ctr: 56)] public float _yawDeltaRequest = 90.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _forwardBackwardAngle = 40.0f;
        [FieldAttr(nst: 68, ctr: 64)] public bool _debugDrawWhiskers = true;
        [FieldAttr(nst: 69, ctr: 65)] public bool _debugDrawHeading = true;
    }
}
