namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8)]
    public class CAISystemData : igSingleton
    {
        [FieldAttr(nst: 16)] public float _interiorCombatCircleDistance = 150.0f;
        [FieldAttr(nst: 20)] public float _exteriorCombatCircleDistance = 400.0f;
        [FieldAttr(nst: 24)] public int _maxInteriorEnemies = 3;
        [FieldAttr(nst: 28)] public float _interiorCombatCircleDistanceVehicle = 500.0f;
        [FieldAttr(nst: 32)] public float _exteriorCombatCircleDistanceVehicle = 1000.0f;
        [FieldAttr(nst: 36)] public int _maxInteriorEnemiesVehicle = 3;
        [FieldAttr(nst: 40)] public float _interiorBufferAngle = 10.0f;
        [FieldAttr(nst: 44)] public float _defaultAwarenessRadius = 1500.0f;
        [FieldAttr(nst: 48)] public float _defaultVehicleAwarenessRadius = 5000.0f;
        [FieldAttr(nst: 52)] public float _defaultUnawarenessBuffer = 1000.0f;
        [FieldAttr(nst: 56)] public float _distancePenalty = 1.0f;
        [FieldAttr(nst: 60)] public float _enemyPenalty = 1000.0f;
        [FieldAttr(nst: 64)] public float _interiorEnemyPenalty = 1.0f;
        [FieldAttr(nst: 68)] public float _playerBonus = 1000.0f;
        [FieldAttr(nst: 72)] public CDamageData? _defaultMeleeDeflectionDamage;
        [FieldAttr(nst: 80)] public CAIAttackCoordinatorData? _attackCoordinatorData;
        [FieldAttr(nst: 88)] public CMapToEnemyTable? _mapToEnemyTable;
        [FieldAttr(nst: 96)] public float _debugSpawnOffset = 100.0f;
    }
}
