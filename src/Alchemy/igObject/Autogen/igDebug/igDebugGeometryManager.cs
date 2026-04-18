namespace Alchemy
{
    [ObjectAttr(nst: 400, ctr: 400, align: 8)]
    public class igDebugGeometryManager : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igProcGeometryBuilder? _pgbTris;
        [FieldAttr(nst: 24, ctr: 24)] public igProcGeometryBuilder? _pgbLines;
        [FieldAttr(nst: 32, ctr: 32)] public igDebugPrimitiveList[] _primLists = new igDebugPrimitiveList[8];
        [FieldAttr(nst: 96, ctr: 96)] public igDebugPrimitivePool? _primPool;
        [FieldAttr(nst: 104, ctr: 104)] public u16 _passId;
        [FieldAttr(nst: 105, ctr: 106)] public u16 _hudPassId;
        [FieldAttr(nst: 112, ctr: 112)] public igMemoryCommandStream[] _stateStream = new igMemoryCommandStream[8];
        [FieldAttr(nst: 176, ctr: 176)] public igDebugGeometryDrawCall[] _drawCall = new igDebugGeometryDrawCall[16];
        [FieldAttr(nst: 304, ctr: 304)] public igSizeTypeMetaField _alphaBlending = new();
        [FieldAttr(nst: 312, ctr: 312)] public igSizeTypeMetaField _depthTestOff = new();
        [FieldAttr(nst: 320, ctr: 320)] public igSizeTypeMetaField _backFaceCulling = new();
        [FieldAttr(nst: 328, ctr: 328)] public igGfxShaderConstantList? _vertexShaderConstants;
        [FieldAttr(nst: 336, ctr: 336)] public igSizeTypeMetaField _pixelShader = new();
        [FieldAttr(nst: 344, ctr: 344)] public igSizeTypeMetaField _vertexShader = new();
        [FieldAttr(nst: 352, ctr: 352, refCount: false)] public igRenderer? _renderer;
        [FieldAttr(nst: 360, ctr: 360)] public bool _active;
        [FieldAttr(nst: 364, ctr: 364)] public int _maximumVertexCount = 131072;
        [FieldAttr(nst: 368, ctr: 368)] public int _vertexCount;
        [FieldAttr(nst: 376, ctr: 376, refCount: false)] public igMemoryPool? _runtimeAllocationPool;
        [FieldAttr(nst: 384, ctr: 384)] public uint _initialPrimitivePoolSize = 256;
        [FieldAttr(nst: 392, ctr: 392)] public igSemaphore? _lock;
    }
}
