namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 16)]
    public class CDebugHighlightColorBundle : igShaderConstantBundle
    {
        [FieldAttr(ctr: 32)] public igVec4fMetaField _color = new();
    }
}
