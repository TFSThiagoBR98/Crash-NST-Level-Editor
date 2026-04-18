namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class igShaderBuffer : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EIG_GFX_PLATFORM _platform;
        [FieldAttr(nst: 20, ctr: 16)] public EIG_GFX_SHADER_TYPE _shaderType;
        [FieldAttr(nst: 24, ctr: 20)] public uint _hash;
        [FieldAttr(nst: 32, ctr: 24)] public igShaderHeader? _header;
        [FieldAttr(nst: 40, ctr: 32)] public igMemoryRef<u8> _shaderData = new();
    }
}
