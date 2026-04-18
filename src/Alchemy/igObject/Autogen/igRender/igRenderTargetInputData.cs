namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igRenderTargetInputData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(nst: 24, ctr: 24)] public int _unitID;
        [FieldAttr(nst: 28, ctr: 28)] public bool _autoBind = true;
        [FieldAttr(nst: 32, ctr: 32)] public EIG_GFX_TEXTURE_FILTER _magFilter;
        [FieldAttr(nst: 36, ctr: 36)] public EIG_GFX_TEXTURE_FILTER _minFilter;
        [FieldAttr(nst: 40, ctr: 40)] public EIG_GFX_TEXTURE_WRAP _wrapS;
        [FieldAttr(nst: 44, ctr: 44)] public EIG_GFX_TEXTURE_WRAP _wrapT;
        [FieldAttr(nst: 48, ctr: 48)] public EIG_GFX_MULTISAMPLE_TYPE _msaaType;
        [FieldAttr(nst: 52, ctr: 52)] public bool _comparisonSampler;
        [FieldAttr(nst: 56, ctr: 56)] public igSizeTypeMetaField _texture = new();
        [FieldAttr(nst: 64, ctr: 64)] public igSizeTypeMetaField _sampler = new();
    }
}
