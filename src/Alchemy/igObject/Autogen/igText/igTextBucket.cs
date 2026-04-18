namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 144, align: 8)]
    public class igTextBucket : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _depth;
        [FieldAttr(nst: 24, ctr: 16)] public igFont? _font;
        [FieldAttr(nst: 32, ctr: 24)] public igScissorNode? _scissor;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _shadowMaterial = new();
        [FieldAttr(nst: 56, ctr: 48)] public float _shadowDepthOffset;
        [FieldAttr(nst: 60, ctr: 52)] public bool _hasValidPassId;
        [FieldAttr(nst: 61, ctr: 54)] public u16 _passId;
        [FieldAttr(nst: 64, ctr: 56)] public string? _modelClass = null;
        [FieldAttr(nst: 72, ctr: 64)] public igBitmapFont? _bitmapFont;
        [FieldAttr(nst: 80, ctr: 72)] public igAttrList? _renderAttrs;
        [FieldAttr(nst: 88, ctr: 80)] public igGroup? _renderNode;
        [FieldAttr(nst: 96, ctr: 88)] public igTextureBindAttr2? _textureBindAttr;
        [FieldAttr(nst: 104, ctr: 96)] public igRawRefMetaField _renderMatrix = new();
        [FieldAttr(nst: 112, ctr: 104)] public igGroup? _root;
        [FieldAttr(nst: 120, ctr: 112)] public int _textCount;
        [FieldAttr(nst: 124, ctr: 116)] public int _vertexCount;
        [FieldAttr(nst: 128, ctr: 120)] public int _shadowVertexCount;
        [FieldAttr(nst: 136, ctr: 128, refCount: false)] public igText? _firstText;
        [FieldAttr(nst: 144, ctr: 136, refCount: false)] public igRenderer? _renderer;
    }
}
