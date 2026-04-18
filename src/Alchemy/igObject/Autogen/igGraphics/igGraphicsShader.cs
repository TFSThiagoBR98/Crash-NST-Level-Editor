namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igGraphicsShader : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igTextureSamplerSourceList? _samplerList;
        [FieldAttr(nst: 32, ctr: 32)] public igGfxShaderConstantList? _stateList;
        [FieldAttr(nst: 40, ctr: 40)] public igShaderBuffer? _shaderBuffer;
        [FieldAttr(nst: 48, ctr: 48)] public igSizeTypeMetaField _resource = new();
    }
}
