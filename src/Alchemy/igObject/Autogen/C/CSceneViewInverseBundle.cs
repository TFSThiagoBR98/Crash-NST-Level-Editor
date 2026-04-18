namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 288, align: 16)]
    public class CSceneViewInverseBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _inverseViewMatrix = new();
        [FieldAttr(nst: 96, ctr: 96)] public igMatrix44fMetaField _viewMatrix = new();
        [FieldAttr(ctr: 160)] public igMatrix44fMetaField _viewProjectionMatrix = new();
        [FieldAttr(ctr: 224)] public igMatrix44fMetaField _projectionMatrix = new();
    }
}
