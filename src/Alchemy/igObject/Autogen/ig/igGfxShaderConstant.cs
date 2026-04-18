namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class igGfxShaderConstant : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public uint _baseRegister;
        [FieldAttr(nst: 32, ctr: 32)] public string? _parameterName = "";
        [FieldAttr(nst: 40, ctr: 40)] public uint _elementSize = 1;
        [FieldAttr(nst: 44, ctr: 44)] public uint _vectorWidth = 4;
        [FieldAttr(nst: 48, ctr: 48)] public uint _elementIndex;
        [FieldAttr(nst: 52, ctr: 52)] public uint _elementCount = 1;
        [FieldAttr(nst: 56, ctr: 56)] public uint _reserved;
        [FieldAttr(nst: 64, ctr: 64)] public igRawRefMetaField _cachedConstant = new();
        [FieldAttr(nst: 72, ctr: 72)] public uint _seqId;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igGfxShaderConstant? _next;
    }
}
