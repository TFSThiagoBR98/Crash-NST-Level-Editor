namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 16)]
    public class igAtmosphericsConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _fogDensity = 0.001f;
        [FieldAttr(nst: 28, ctr: 28)] public float _fogStart;
        [FieldAttr(nst: 32, ctr: 32)] public float _fogDistanceScale = 1.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _fogIntensity = 1.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _fogSunScale = 0.5f;
        [FieldAttr(nst: 44, ctr: 44)] public float _fogSunBias = 0.5f;
        [FieldAttr(nst: 48, ctr: 48)] public float _fogSunInfluence = 1.0f;
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _fogColor = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _fogSunDirection = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _fogSunColor = new();
        [FieldAttr(nst: 112, ctr: 112)] public float _cloudCoverScale;
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _cloudCoverOffset = new();
    }
}
