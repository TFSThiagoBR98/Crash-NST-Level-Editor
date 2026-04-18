namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 16)]
    public class CVertexWibbleParametersBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _amplitude = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _frequency = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _phase = new();
    }
}
