namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 240, align: 8)]
    public class igSpriteManager : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _defaultModelClass = "hud";
        [FieldAttr(nst: 24, ctr: 24)] public igObjectPool? _spritePool;
        [FieldAttr(nst: 32, ctr: 32)] public igObjectPool? _bucketPool;
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igSpriteBucket> _buckets = new();
        [FieldAttr(nst: 64, ctr: 64)] public igSpriteDrawCallPool? _drawCallPool;
        [FieldAttr(nst: 72, ctr: 72)] public u16 _defaultCommonState;
        [FieldAttr(nst: 74, ctr: 74)] public u16 _forceBlendCommonState;
        [FieldAttr(nst: 76, ctr: 76)] public u16 _useMaterialBlendCommonState;
        [FieldAttr(nst: 80, ctr: 80)] public igSizeTypeMetaField _repeatLinearSampler = new();
        [FieldAttr(nst: 88, ctr: 88)] public igSizeTypeMetaField _repeatMipmapSampler = new();
        [FieldAttr(nst: 96, ctr: 96)] public igSizeTypeMetaField _clampLinearSampler = new();
        [FieldAttr(nst: 104, ctr: 104)] public igSizeTypeMetaField _clampMipmapSampler = new();
        [FieldAttr(nst: 112, ctr: 112)] public igGfxShaderConstantList? _textureVertexShaderConstants;
        [FieldAttr(nst: 120, ctr: 120)] public igSizeTypeMetaField _texturePixelShader = new();
        [FieldAttr(nst: 128, ctr: 128)] public igSizeTypeMetaField _textureVertexShader = new();
        [FieldAttr(nst: 136, ctr: 136)] public igGraphicsEffect? _textureEffect;
        [FieldAttr(nst: 144, ctr: 144)] public igGfxShaderConstantList? _colorVertexShaderConstants;
        [FieldAttr(nst: 152, ctr: 152)] public igSizeTypeMetaField _colorPixelShader = new();
        [FieldAttr(nst: 160, ctr: 160)] public igSizeTypeMetaField _colorVertexShader = new();
        [FieldAttr(nst: 168, ctr: 168)] public igGraphicsEffect? _colorEffect;
        [FieldAttr(nst: 176, ctr: 176)] public igProcGeometryBuilder? _nonTexturedPgb;
        [FieldAttr(nst: 184, ctr: 184)] public igProcGeometryBuilder? _texturedPgb;
        [FieldAttr(nst: 192, ctr: 192)] public igProcGeometryBuilder? _textured2UvPgb;
        [FieldAttr(nst: 200, ctr: 200, refCount: false)] public igRenderer? _renderer;
        [FieldAttr(nst: 208, ctr: 208)] public igMutex? _lock;
        [FieldAttr(nst: 216, ctr: 216)] public igVec2fMetaField _windowMin = new();
        [FieldAttr(nst: 224, ctr: 224)] public igVec2fMetaField _windowMax = new();
        [FieldAttr(nst: 232, ctr: 232)] public bool _toolViewerIsRunning;
    }
}
