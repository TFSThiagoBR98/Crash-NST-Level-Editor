namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CAmbientOcclusionShaderConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _radius = 50.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _invRadius = 0.02f;
        [FieldAttr(nst: 32, ctr: 32)] public float _radiusSquared = 2500.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _projScale = 1.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _adjustedRadius = 50.0f;
        [FieldAttr(nst: 44, ctr: 44)] public float _normalizeTerm = 0.000016f;
        [FieldAttr(nst: 48, ctr: 48)] public float _scale = 1.5f;
        [FieldAttr(nst: 52, ctr: 52)] public float _bias = 1.0f;
        [FieldAttr(nst: 56, ctr: 56)] public float _clampedRadiusMin = 10.0f;
        [FieldAttr(nst: 60, ctr: 60)] public float _clampedRadiusMax = 24.0f;
        [FieldAttr(nst: 64)] public bool _ambientOcclusionState = true;
    }
}
