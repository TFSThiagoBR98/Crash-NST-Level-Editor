namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 208, align: 8)]
    public class igTextManager : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _defaultModelClass = "hud";
        [FieldAttr(nst: 24, ctr: 24)] public igFont? _defaultFont;
        [FieldAttr(nst: 32, ctr: 32)] public igTextPool? _textPool;
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igText> _textsToDelete = new();
        [FieldAttr(nst: 64, ctr: 64)] public igTextBucketPool? _bucketPool;
        [FieldAttr(nst: 72, ctr: 72)] public igVectorMetaField<igTextBucket> _buckets = new();
        [FieldAttr(nst: 96, ctr: 96)] public igTextDrawCallPool? _drawCallPool;
        [FieldAttr(nst: 104, ctr: 104)] public igMemoryCommandStream? _defaultState;
        [FieldAttr(nst: 112, ctr: 112)] public igSizeTypeMetaField _alphaBlending = new();
        [FieldAttr(nst: 120, ctr: 120)] public igSizeTypeMetaField _depthWriteOff = new();
        [FieldAttr(nst: 128, ctr: 128)] public igSizeTypeMetaField _backFaceCulling = new();
        [FieldAttr(nst: 136, ctr: 136)] public igGfxShaderConstantList? _vertexShaderConstants;
        [FieldAttr(nst: 144, ctr: 144)] public igSizeTypeMetaField _pixelShader = new();
        [FieldAttr(nst: 152, ctr: 152)] public igSizeTypeMetaField _vertexShader = new();
        [FieldAttr(nst: 160, ctr: 160)] public igProcGeometryBuilder? _pgb;
        [FieldAttr(nst: 168, ctr: 168, refCount: false)] public igRenderer? _renderer;
        [FieldAttr(nst: 176, ctr: 176)] public igMutex? _lock;
        [FieldAttr(nst: 184, ctr: 184)] public igVec2fMetaField _windowMin = new();
        [FieldAttr(nst: 192, ctr: 192)] public igVec2fMetaField _windowMax = new();
        [FieldAttr(nst: 200, ctr: 200)] public bool _toolViewerIsRunning;
    }
}
