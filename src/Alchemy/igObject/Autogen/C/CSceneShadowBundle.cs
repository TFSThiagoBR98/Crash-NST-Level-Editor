namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CSceneShadowBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _state;
        [FieldAttr(nst: 25, ctr: 25)] public bool _fadeState;
        [FieldAttr(nst: 28, ctr: 28)] public float _fade = 1.0f;
    }
}
