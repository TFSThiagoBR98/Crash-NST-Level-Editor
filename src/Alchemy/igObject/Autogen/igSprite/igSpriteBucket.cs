namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class igSpriteBucket : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _depth;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _image = new();
        [FieldAttr(nst: 40, ctr: 32, refCount: false)] public igSpriteDrawCallModifier? _modifier;
        [FieldAttr(nst: 48, ctr: 40)] public bool _hasValidPassId;
        [FieldAttr(nst: 49, ctr: 42)] public u16 _passId;
        [FieldAttr(nst: 50, ctr: 44)] public bool _blendState;
        [FieldAttr(nst: 56, ctr: 48)] public igRawRefMetaField _extraUvs = new();
        [FieldAttr(nst: 64, ctr: 56)] public igScissorNode? _scissor;
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 80, ctr: 72)] public igSizeTypeMetaField _texture = new();
        [FieldAttr(nst: 88, ctr: 80)] public igSizeTypeMetaField _sampler = new();
        [FieldAttr(nst: 96, ctr: 88)] public int _spriteCount;
        [FieldAttr(nst: 104, ctr: 96, refCount: false)] public igSprite? _firstSprite;
        [FieldAttr(nst: 112, ctr: 104, refCount: false)] public igRenderer? _renderer;
        [FieldAttr(nst: 120, ctr: 112)] public uint _hash;
    }
}
