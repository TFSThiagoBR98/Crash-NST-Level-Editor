namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class CProjectiveShadowParametersBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _worldToLightMatrix = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _edgeFade = new();
        [FieldAttr(nst: 112, ctr: 112)] public float _intensity;
    }
}
