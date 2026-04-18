namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 160, align: 16)]
    public class igRenderer : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igDebugGeometryManager? _debugGeometry;
        [FieldAttr(nst: 24, ctr: 24)] public igRenderPassManager? _passManager;
        [FieldAttr(nst: 32, ctr: 32)] public igSpriteManager? _spriteManager;
        [FieldAttr(nst: 40, ctr: 40)] public igTextManager? _textManager;
        [FieldAttr(nst: 48, ctr: 48)] public igAtomicSortKeyValueListMetaField _sortKeyList = new();
        [FieldAttr(nst: 72, ctr: 72)] public igVectorMetaField<igCommandStreamEncoder> _encoders = new();
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _encodeTimeState = new();
        [FieldAttr(nst: 100, ctr: 100)] public igHandleMetaField _commandStreamMemoryUsageState = new();
        [FieldAttr(nst: 104)] public igRawRefMetaField _debugCallback = new();
        [FieldAttr(nst: 112)] public igRawRefMetaField _vfxPostUpdateCallback = new();
        [FieldAttr(nst: 120, ctr: 120)] public bool _lockOnOperation;
        [FieldAttr(nst: 121)] public bool _enabled4K;
        [FieldAttr(nst: 122, ctr: 121)] public bool _active;
        [FieldAttr(nst: 128, ctr: 128)] public igModelScene? _modelScene;
        [FieldAttr(nst: 144, ctr: 144)] public int _encodeJobCounter;
    }
}
