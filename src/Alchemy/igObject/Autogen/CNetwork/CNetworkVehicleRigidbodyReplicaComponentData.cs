namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class CNetworkVehicleRigidbodyReplicaComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _setPositionByLinearVelocity = true;
        [FieldAttr(nst: 28)] public float _setPositionByLinearVelocityDuration = 0.5f;
        [FieldAttr(nst: 32)] public float _minPositionDeltaForSetByVelocity = 10.0f;
        [FieldAttr(nst: 36)] public float _staticPositionDeltaUntilTeleport = 2000.0f;
        [FieldAttr(nst: 40)] public float _restingPositionDeltaUntilTeleport = 50.0f;
        [FieldAttr(nst: 44)] public float _maxPredictedPositionTimeDeltaUntilTeleport = 2.0f;
        [FieldAttr(nst: 48)] public bool _useRestingGravity;
        [FieldAttr(nst: 49)] public bool _useLinearVelocity = true;
        [FieldAttr(nst: 52)] public float _minimumMovementForLinearVelocity = 5.0f;
        [FieldAttr(nst: 56)] public float _maxRacingSpeedForLinearInterpolation = 4000.0f;
    }
}
