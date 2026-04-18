namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CVehicleSection : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _cameraBlendTime = 1.0f;
        [FieldAttr(nst: 24, ctr: 16)] public CCameraBase? _defaultCamera;
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _splineEntity = new();
        [FieldAttr(nst: 40, ctr: 32)] public igSpline2? _spline2;
        [FieldAttr(nst: 48, ctr: 40)] public CLinearVehicleSplineMover? _splineMover;
        [FieldAttr(nst: 56, ctr: 48)] public float _splineBaseMovementSpeed = 2500.0f;
        [FieldAttr(nst: 64, ctr: 56)] public igHandleMetaField _vehicleSettingsOverride = new();
    }
}
