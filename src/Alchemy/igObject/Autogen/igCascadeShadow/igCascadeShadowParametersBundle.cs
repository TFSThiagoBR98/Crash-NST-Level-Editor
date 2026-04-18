namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 288, align: 16)]
    public class igCascadeShadowParametersBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _shiftX = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _shiftY = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _shiftZ = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _scaleX = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _scaleY = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _scaleZ = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _blend = new();
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _worldToLightMatrix = new();
        [FieldAttr(nst: 208, ctr: 208)] public igMatrix44fMetaField _viewToLightMatrix = new();
        [FieldAttr(nst: 272, ctr: 272)] public igVec4fMetaField _viewspaceLightDirection = new();
    }
}
