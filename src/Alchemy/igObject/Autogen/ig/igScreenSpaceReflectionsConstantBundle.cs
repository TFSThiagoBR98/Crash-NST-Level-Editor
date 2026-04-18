namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class igScreenSpaceReflectionsConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(ctr: 32)] public igVec4fMetaField _params = new();
        [FieldAttr(ctr: 48)] public igVec4fMetaField _params2 = new();
        [FieldAttr(ctr: 64)] public bool _enabled;
    }
}
