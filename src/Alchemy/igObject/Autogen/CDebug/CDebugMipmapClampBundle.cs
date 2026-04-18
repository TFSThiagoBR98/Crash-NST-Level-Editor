namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 16)]
    public class CDebugMipmapClampBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField _clamp = new();
        [FieldAttr(nst: 48)] public igVec4fMetaField _clamp2 = new();
    }
}
