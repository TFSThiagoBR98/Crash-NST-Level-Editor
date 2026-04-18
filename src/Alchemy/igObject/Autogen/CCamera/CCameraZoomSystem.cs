namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CCameraZoomSystem : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _stickyCameraZoomDuration = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _cameraZoomOutDampingFactor = 0.2f;
        [FieldAttr(nst: 24, ctr: 20)] public float _cameraZoomInDampingFactor = 0.05f;
        [FieldAttr(nst: 28, ctr: 24)] public float _previousCameraZoomDistance;
        [FieldAttr(nst: 32, ctr: 28)] public float _stickyCameraZoomRunningTime;
        [FieldAttr(nst: 36, ctr: 32)] public float _currentCameraZoomDistance;
        [FieldAttr(nst: 40, ctr: 36)] public bool _isCameraZoomCapped;
        [FieldAttr(nst: 41, ctr: 37)] public bool _isCameraZoomStickied;
        [FieldAttr(nst: 44, ctr: 40)] public float _cameraZoomDampingVelocity;
        [FieldAttr(nst: 48, ctr: 48)] public igPlane? _leftPlane;
        [FieldAttr(nst: 56, ctr: 56)] public igPlane? _rightPlane;
        [FieldAttr(nst: 64, ctr: 64)] public igPlane? _bottomPlane;
        [FieldAttr(nst: 72, ctr: 72)] public igPlane? _topPlane;
        [FieldAttr(nst: 80, ctr: 80)] public igRay? _ray;
    }
}
