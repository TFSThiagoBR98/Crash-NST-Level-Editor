namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 112, align: 16)]
    public class CHeroShadowsFullscreenBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _state;
        [FieldAttr(nst: 25)] public bool _coop;
        [FieldAttr(nst: 32)] public igMatrix44fMetaField _heroViewToLightMatrix1 = new();
        [FieldAttr(nst: 96)] public igMatrix44fMetaField _heroViewToLightMatrix2 = new();
        [FieldAttr(nst: 160)] public float _fade1 = 1.0f;
        [FieldAttr(nst: 164)] public float _fade2 = 1.0f;
        [FieldAttr(ctr: 32)] public igMatrix44fMetaField _heroViewToLightMatrix = new();
        [FieldAttr(ctr: 96)] public float _fade;
        [FieldAttr(nst: 168, ctr: 100)] public bool _fadeState;
    }
}
