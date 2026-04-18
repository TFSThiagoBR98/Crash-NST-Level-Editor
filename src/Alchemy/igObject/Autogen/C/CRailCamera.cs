namespace Alchemy
{
    [ObjectAttr(ctr: 512, align: 16)]
    public class CRailCamera : CConstrainedCamera
    {
        [FieldAttr(ctr: 464)] public igSpline? _rail;
        [FieldAttr(ctr: 472)] public igSpline? _spline;
        [FieldAttr(ctr: 480)] public bool _lockRotationToSpline;
        [FieldAttr(ctr: 481)] public bool _subdivideLargeSegments;
        [FieldAttr(ctr: 484)] public float _maximumSegmentRatio;
        [FieldAttr(ctr: 488)] public float _positionOnSpline;
        [FieldAttr(ctr: 492)] public float _maxCameraSpeed;
        [FieldAttr(ctr: 496)] public CRailCameraPeachesCallback? _peachesCallback;
    }
}
