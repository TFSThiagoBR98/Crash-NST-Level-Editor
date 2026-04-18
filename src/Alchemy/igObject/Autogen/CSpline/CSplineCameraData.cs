namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class CSplineCameraData : igObject
    {
        public enum ERelativeOffsetSource
        {
            eROS_SplineRelative = 0,
            eROS_CameraRelative = 1,
        }

        [FieldAttr(nst: 16, ctr: 12)] public ESplineMode _splineCameraMode;
        [FieldAttr(nst: 20, ctr: 16)] public EStartDistanceDirection _startDistanceDirection;
        [FieldAttr(nst: 24, ctr: 20)] public float _minDistanceDuringForwardMovement;
        [FieldAttr(nst: 28, ctr: 24)] public float _minDistanceDuringBackwardMovement;
        [FieldAttr(nst: 32, ctr: 28)] public float _minDistanceDuringVerticalMovement = -300.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _pitchOffsetDuringForwardMovement;
        [FieldAttr(nst: 40, ctr: 36)] public float _pitchOffsetDuringBackwardMovement;
        [FieldAttr(nst: 44, ctr: 40)] public float _pitchOffsetDuringVerticalMovement;
        [FieldAttr(nst: 48, ctr: 44)] public ERelativeOffsetSource _pitchRelativeSource = CSplineCameraData.ERelativeOffsetSource.eROS_CameraRelative;
        [FieldAttr(nst: 52, ctr: 48)] public float _positionDamping = 0.15f;
        [FieldAttr(nst: 56, ctr: 52)] public float _rotationDamping = 0.1f;
        [FieldAttr(nst: 60, ctr: 56)] public float _distanceDamping = 0.15f;
        [FieldAttr(nst: 64, ctr: 60)] public float _directionChangeMinAngle = 25.0f;
        [FieldAttr(nst: 72, ctr: 64)] public CPlayerFollowData? _yawPlayerFollowData;
        [FieldAttr(nst: 80, ctr: 72)] public CPlayerFollowData? _pitchPlayerFollowData;
        [FieldAttr(nst: 88, ctr: 80)] public CSplineOffsetData? _splineOffsetData;
        [FieldAttr(nst: 96, ctr: 88)] public float _minSplineInputInfluence;
        [FieldAttr(nst: 100, ctr: 92)] public float _maxSplineInputInfluence;
        [FieldAttr(nst: 104, ctr: 96)] public float _minSplineInputInfluenceThreshold;
        [FieldAttr(nst: 108, ctr: 100)] public float _maxSplineInputInfluenceThreshold = 15.0f;
        [FieldAttr(nst: 112, ctr: 104)] public float _maxInputYawFollowOffset = -1.0f;
        [FieldAttr(nst: 116, ctr: 108)] public float _maxInputYawDifference = -1.0f;
        [FieldAttr(ctr: 112)] public float _distanceOffsetAlongSpline;
    }
}
