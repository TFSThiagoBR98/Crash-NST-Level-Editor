namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igImageInputData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _image = new();
        [FieldAttr(nst: 24, ctr: 24)] public int _unitID;
        [FieldAttr(nst: 28, ctr: 28)] public EIG_GFX_TEXTURE_FILTER _magFilter;
        [FieldAttr(nst: 32, ctr: 32)] public EIG_GFX_TEXTURE_FILTER _minFilter;
        [FieldAttr(nst: 36, ctr: 36)] public EIG_GFX_TEXTURE_WRAP _wrapS;
        [FieldAttr(nst: 40, ctr: 40)] public EIG_GFX_TEXTURE_WRAP _wrapT;
        [FieldAttr(nst: 44, ctr: 44)] public EIG_GFX_TEXTURE_WRAP _wrapR;
        [FieldAttr(nst: 48, ctr: 48)] public igSizeTypeMetaField _sampler = new();
    }
}
