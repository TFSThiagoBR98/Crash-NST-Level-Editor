namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 184, align: 8)]
    public class CVehicleCollisionResponseCriteria : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _isEnabled = true;
        [FieldAttr(nst: 28, ctr: 28)] public float _sourceMinSpeedRatio = -10.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _sourceMaxSpeedRatio = 10.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _targetMinSpeedRatio = -10.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _targetMaxSpeedRatio = 10.0f;
        [FieldAttr(nst: 44, ctr: 44)] public float _combinedMinSpeedRatio = -10.0f;
        [FieldAttr(nst: 48, ctr: 48)] public float _combinedMaxSpeedRatio = 10.0f;
        [FieldAttr(nst: 52, ctr: 52)] public float _minWeightDiff = -500.0f;
        [FieldAttr(nst: 56, ctr: 56)] public float _maxWeightDiff = 500.0f;
        [FieldAttr(nst: 60, ctr: 60)] public i16 _priority;
        [FieldAttr(nst: 64, ctr: 64)] public EVehicleCollisionTriState _worldCollision;
        [FieldAttr(nst: 68, ctr: 68)] public EVehicleCollisionTriState _levelBorderCollision;
        [FieldAttr(nst: 72, ctr: 72)] public EVehicleCollisionTriState _destructibleCollision = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 76, ctr: 76)] public uint _teamRelationship = 7;
        [FieldAttr(nst: 80, ctr: 80)] public EVehicleCollisionCriteriaOwner _criteriaOwner;
        [FieldAttr(nst: 84, ctr: 84)] public EVehicleCollisionTriState _blockingCollision = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 88, ctr: 88)] public EVehicleCollisionTriState _sourceDriftingIntoCollision = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 92, ctr: 92)] public EVehicleCollisionTriState _sourceIsPlayer = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 96, ctr: 96)] public EVehicleCollisionTriState _sourceIsVehicle = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 100, ctr: 100)] public EVehicleCollisionTriState _sourceIsOnSurface = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 104, ctr: 104)] public EVehicleCollisionTriState _sourceIsOnSpline;
        [FieldAttr(nst: 108, ctr: 108)] public EVehicleCollisionTriState _targetIsPlayer = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 112, ctr: 112)] public EVehicleCollisionTriState _targetDriftingIntoCollision = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 116, ctr: 116)] public EVehicleCollisionTriState _targetIsVehicle = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 120, ctr: 120)] public EVehicleCollisionTriState _targetIsOnSurface = EVehicleCollisionTriState.eVCTS_Either;
        [FieldAttr(nst: 124, ctr: 124)] public EVehicleCollisionTriState _targetIsOnSpline;
        [FieldAttr(nst: 128, ctr: 128)] public EVehicleCollisionWeightClassRelationship _weightClassRelationship = EVehicleCollisionWeightClassRelationship.eVCWC_All;
        [FieldAttr(nst: 136, ctr: 136)] public CVehicleCollisionResponse? _sourceResponse;
        [FieldAttr(nst: 144, ctr: 144)] public CVehicleCollisionResponse? _targetResponse;
        [FieldAttr(nst: 152, ctr: 152)] public float _sourceMinForwardDot = 2.0f;
        [FieldAttr(nst: 156, ctr: 156)] public float _sourceMaxForwardDot = -2.0f;
        [FieldAttr(nst: 160, ctr: 160)] public float _sourceMinWorldZDot = 2.0f;
        [FieldAttr(nst: 164, ctr: 164)] public float _sourceMaxWorldZDot = -2.0f;
        [FieldAttr(nst: 168, ctr: 168)] public float _targetMinForwardDot = 2.0f;
        [FieldAttr(nst: 172, ctr: 172)] public float _targetMaxForwardDot = -2.0f;
        [FieldAttr(nst: 176, ctr: 176)] public float _targetMinWorldZDot = 2.0f;
        [FieldAttr(nst: 180, ctr: 180)] public float _targetMaxWorldZDot = -2.0f;
    }
}
