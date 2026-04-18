namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8)]
    public class CSplineLaneMoverComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igHandleMetaField _splineEntity = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _splineStart = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _splineEnd = new();
        [FieldAttr(nst: 48)] public bool _teleportToStartOnEnable;
        [FieldAttr(nst: 49)] public bool _startOnEnable;
        [FieldAttr(nst: 52)] public ESplineLaneMoverForwardMovementType _forwardMovementType;
        [FieldAttr(nst: 56)] public float _forwardVelocity = 1000.0f;
        [FieldAttr(nst: 60)] public bool _useTimeBasedVelocity;
        [FieldAttr(nst: 64)] public float _timeToCompleteSpline = 1.0f;
        [FieldAttr(nst: 68)] public float _easeVelocityFactor = 0.89999998f;
        [FieldAttr(nst: 72)] public EigEaseType _easeInType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 76)] public float _easeInFraction;
        [FieldAttr(nst: 80)] public EigEaseType _easeOutType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 84)] public float _easeOutFraction;
        [FieldAttr(nst: 88)] public bool _startReversed;
        [FieldAttr(nst: 89)] public bool _ignoreVelocityKeyframes = true;
        [FieldAttr(nst: 92)] public ESplineLaneMoverHorizontalMovementType _horizontalMovementType;
        [FieldAttr(nst: 96)] public float _horizontalVelocity = 1000.0f;
        [FieldAttr(nst: 100)] public float _horizontalAcceleration = 1000.0f;
        [FieldAttr(nst: 104)] public float _horizontalConvergence = 1.0f;
        [FieldAttr(nst: 108)] public float _spacingFromLaneEdges;
        [FieldAttr(nst: 112)] public float _splineTurnInfluence;
        [FieldAttr(nst: 116)] public ESplineLaneMoverVerticalMovementType _verticalMovementType;
        [FieldAttr(nst: 120)] public float _slopeCompensation;
        [FieldAttr(nst: 124)] public bool _verticalMovementWhileStopped;
        [FieldAttr(nst: 128)] public ESplineLaneMoverOrientationType _orientationType = ESplineLaneMoverOrientationType.eSLMO_FaceAlongSpline;
        [FieldAttr(nst: 132)] public ESplineLaneMoverUpOrientation _upOrientation;
        [FieldAttr(nst: 136)] public float _orientationTime = 0.2f;
        [FieldAttr(nst: 140)] public float _splineTurnExaggeration = 1.0f;
        [FieldAttr(nst: 144)] public float _turnFadeOuterEdge = 100.0f;
        [FieldAttr(nst: 148)] public float _turnFadeOuterFactor = 1.0f;
        [FieldAttr(nst: 152)] public float _turnFadeInnerEdge;
        [FieldAttr(nst: 156)] public float _turnFadeInnerFactor = 1.0f;
    }
}
