namespace Alchemy
{
    [ObjectAttr(nst: 304, ctr: 304, align: 16)]
    public class CSkyboxConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _skyIntensity = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _sunIntensity = 10.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _sunExponent = 2048.0f;
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _sunDirection = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _sunColor = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _sunshaftColor = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _sunshaftOrigin = new();
        [FieldAttr(nst: 112, ctr: 112)] public float _sunshaftFade = 1.0f;
        [FieldAttr(nst: 116, ctr: 116)] public float _sunshaftDecay = 0.999f;
        [FieldAttr(nst: 120, ctr: 120)] public float _sunshaftDensity = 1.0f;
        [FieldAttr(nst: 124, ctr: 124)] public float _sunshaftIntensity = 1.0f;
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField[] _sunshaftWeights = new igVec4fMetaField[10];
        [FieldAttr(nst: 288, ctr: 288)] public float _skyboxFade = 1.0f;
    }
}
