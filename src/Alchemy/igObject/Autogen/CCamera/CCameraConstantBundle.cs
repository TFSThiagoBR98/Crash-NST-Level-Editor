namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 176, align: 16)]
    public class CCameraConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _direction = new();
        [FieldAttr(nst: 48, ctr: 48)] public igMatrix44fMetaField _cameraFacingMatrix = new();
        [FieldAttr(nst: 112, ctr: 112)] public igMatrix44fMetaField _shadowCameraFacingMatrix = new();
    }
}
