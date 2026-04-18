namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class igRenderTargetCustomData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(ctr: 24)] public int _unitID;
        [FieldAttr(ctr: 28)] public EIG_GFX_TEXTURE_FILTER _magFilter;
        [FieldAttr(ctr: 32)] public EIG_GFX_TEXTURE_FILTER _minFilter;
        [FieldAttr(ctr: 36)] public EIG_GFX_TEXTURE_WRAP _wrapS;
        [FieldAttr(ctr: 40)] public EIG_GFX_TEXTURE_WRAP _wrapT;
        [FieldAttr(ctr: 44)] public EIG_GFX_MULTISAMPLE_TYPE _msaaType;
        [FieldAttr(ctr: 48)] public igTextureBindAttr2? _textureBind;
        [FieldAttr(ctr: 56)] public igTextureAttr2? _texture;
    }
}
