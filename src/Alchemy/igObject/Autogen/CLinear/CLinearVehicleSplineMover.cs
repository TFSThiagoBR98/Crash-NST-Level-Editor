namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CLinearVehicleSplineMover : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _currentSpeed;
        [FieldAttr(nst: 20, ctr: 16)] public float _distanceOnSpline;
        [FieldAttr(nst: 24, ctr: 24)] public CFlightControlLinearCameraSpline? _spline;
        [FieldAttr(nst: 32, ctr: 32)] public igSpline2? _spline2;
        [FieldAttr(nst: 40, ctr: 40)] public CSplineKeyframedVelocityMover? _splineKeyframedVelocityMover;
        [FieldAttr(nst: 48, ctr: 48)] public float _cameraFollowDistanceOffset;
        [FieldAttr(nst: 52, ctr: 52)] public float _boostDistanceMax;
        [FieldAttr(nst: 56, ctr: 56)] public float _brakeDistanceMax;
        [FieldAttr(nst: 60, ctr: 60)] public bool _igSpline2 = true;
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _primaryVehicle = new();
    }
}
