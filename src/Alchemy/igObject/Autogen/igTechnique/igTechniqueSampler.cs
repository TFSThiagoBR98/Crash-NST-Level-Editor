namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igTechniqueSampler : igNamedObject
    {
        [FieldAttr(nst: 24)] public int _unitID;
        [FieldAttr(nst: 28)] public EIG_GFX_TEXTURE_FILTER _magFilter;
        [FieldAttr(nst: 32)] public EIG_GFX_TEXTURE_FILTER _minFilter;
        [FieldAttr(nst: 36)] public EIG_GFX_TEXTURE_WRAP _wrapS = EIG_GFX_TEXTURE_WRAP.REPEAT;
        [FieldAttr(nst: 40)] public EIG_GFX_TEXTURE_WRAP _wrapT = EIG_GFX_TEXTURE_WRAP.REPEAT;
        [FieldAttr(nst: 44)] public uint _formatHint;
        [FieldAttr(nst: 48)] public bool _vertexSampler;
        [FieldAttr(nst: 49)] public bool _useMaterialSamplerState;
        [FieldAttr(nst: 50)] public bool _useMaterialSamplerWrap;
    }
}
