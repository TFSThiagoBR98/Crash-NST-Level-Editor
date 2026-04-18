namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 16)]
    public class igOutdoorLightConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _direction = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _ambientScale = new();
    }
}
