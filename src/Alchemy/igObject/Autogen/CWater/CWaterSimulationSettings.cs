namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 56, align: 4)]
    public class CWaterSimulationSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _accelerationScale = 10.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _velocityScale = 60.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _dampenScale = 1.5f;
        [FieldAttr(nst: 28, ctr: 24)] public float _simulationUnitScale = 8.0f;
        [FieldAttr(ctr: 28)] public float _minRandomSpawnRate;
        [FieldAttr(ctr: 32)] public float _maxRandomSpawnRate;
        [FieldAttr(ctr: 36)] public float _minRandomRadius;
        [FieldAttr(ctr: 40)] public float _maxRandomRadius;
        [FieldAttr(ctr: 44)] public float _minRandomIntensity;
        [FieldAttr(ctr: 48)] public float _maxRandomIntensity;
        [FieldAttr(ctr: 52)] public float _maxRandomExtents;
    }
}
