namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class igPS4ShaderHeader : igShaderHeader
    {
        [FieldAttr(ctr: 32)] public igRawRefMetaField _shader = new();
        [FieldAttr(ctr: 40)] public igRawRefMetaField _resourceOffsets = new();
        [FieldAttr(ctr: 48)] public igVectorMetaField<igPS4InputElementMetaField> _inputElements = new();
        [FieldAttr(ctr: 72)] public igVectorMetaField<igRawRefMetaField> _constantBufferMemory = new();
        [FieldAttr(ctr: 96)] public igVectorMetaField<igSizeTypeMetaField> _constantBufferMemorySize = new();
        [FieldAttr(ctr: 120)] public igVectorMetaField<int> _constantBufferIndices = new();
    }
}
