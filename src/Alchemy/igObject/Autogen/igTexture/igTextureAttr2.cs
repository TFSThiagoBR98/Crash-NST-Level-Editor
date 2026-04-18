namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class igTextureAttr2 : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public uint _formatHint;
        [FieldAttr(nst: 28, ctr: 24)] public bool _loadInVramForCtr;
        [FieldAttr(nst: 32, ctr: 28)] public EIG_GFX_TEXTURE_FILTER _magFilter;
        [FieldAttr(nst: 36, ctr: 32)] public EIG_GFX_TEXTURE_FILTER _minFilter;
        [FieldAttr(nst: 40, ctr: 36)] public EIG_GFX_TEXTURE_WRAP _wrapS = EIG_GFX_TEXTURE_WRAP.REPEAT;
        [FieldAttr(nst: 44, ctr: 40)] public EIG_GFX_TEXTURE_WRAP _wrapT = EIG_GFX_TEXTURE_WRAP.REPEAT;
        [FieldAttr(nst: 48, ctr: 44)] public EIG_GFX_MULTISAMPLE_TYPE _msaaType;
        [FieldAttr(nst: 52, ctr: 48)] public EIG_GFX_TEXTURE_SOURCE _source;
        [FieldAttr(nst: 56, ctr: 56)] public igImage2? _image;
        [FieldAttr(nst: 64, ctr: 64)] public igRawRefMetaField _videoBuffer = new();
        [FieldAttr(nst: 72, ctr: 72)] public int _texHandle = -1;
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _imageHandle = new();
        [FieldAttr(nst: 88, ctr: 88)] public EIG_GFX_TEXTURE_WRAP _wrapR = EIG_GFX_TEXTURE_WRAP.REPEAT;
        [FieldAttr(nst: 92, ctr: 92)] public bool _filterFixedUp;
    }
}
