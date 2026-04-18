namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 160, align: 16)]
    public class CCloudShadingBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _cloudsLightVertical = 0.5f;
        [FieldAttr(nst: 28, ctr: 28)] public float _cloudsLightWrap = 0.6f;
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _cloudsLitColor = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _cloudsDarkColor = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _cloudsHighlightColor = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _cloudsHighlightParams = new();
        [FieldAttr(nst: 96, ctr: 96)] public float _cloudsShadowStrength = 0.2f;
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _cloudsShadowColor = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _cloudsShadowParams = new();
        [FieldAttr(nst: 144, ctr: 144)] public float _cloudsHazeStrength = 1.0f;
    }
}
