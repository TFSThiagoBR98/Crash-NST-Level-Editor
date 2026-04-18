namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 208, align: 8)]
    public class igVfxPrimitiveInfo : igVfxRuntimeObjectInfo
    {
        [FieldAttr(nst: 48, ctr: 48)] public igMetaObject? _dataType;
        [FieldAttr(nst: 56, ctr: 56)] public igMetaObject? _instancePoolType;
        [FieldAttr(nst: 64, ctr: 64)] public igVfxPrimitiveInstancePool? _instancePool;
        [FieldAttr(nst: 72, ctr: 72)] public uint _instancePoolSize = 32;
        [FieldAttr(nst: 76, ctr: 76)] public uint _spawnGroupCount = 1;
        [FieldAttr(nst: 80, ctr: 80)] public uint _windingFlips = 3;
        [FieldAttr(nst: 88, ctr: 88)] public igVfxPrimitiveList? _primitiveList;
        [FieldAttr(nst: 96, ctr: 96)] public igVfxPrimitiveList? _latePrimitiveList;
        [FieldAttr(nst: 104, ctr: 104)] public igStreamList? _streamList;
        [FieldAttr(nst: 112, ctr: 112)] public igProcGeometryHelperList? _pghList;
        [FieldAttr(nst: 120, ctr: 120)] public igIntList? _pgbIndexList;
        [FieldAttr(nst: 128, ctr: 128)] public igVectorMetaField<igRawRefMetaField> _drawCallDataVector = new();
        [FieldAttr(nst: 152, ctr: 152)] public igFxMaterialHandleList? _materialList;
        [FieldAttr(nst: 160, ctr: 160)] public igUnsignedCharList? _spawnGroupList;
        [FieldAttr(nst: 168, ctr: 168)] public igUnsignedCharList? _cameraIndexList;
        [FieldAttr(nst: 176, ctr: 176)] public igUnsignedShortList? _layerList;
        [FieldAttr(nst: 184, ctr: 184)] public bool _useInPrioritySystem = true;
        [FieldAttr(nst: 185, ctr: 185)] public bool _shouldClearSceneRoot;
        [FieldAttr(nst: 188, ctr: 188)] public int _primitiveIndex;
        [FieldAttr(nst: 192, ctr: 192)] public igHandleMetaField _instanceCountStat = new();
        [FieldAttr(nst: 196, ctr: 196)] public igHandleMetaField _primitiveCountStat = new();
        [FieldAttr(nst: 200, ctr: 200)] public igHandleMetaField _instanceBudgetStat = new();
        [FieldAttr(nst: 204, ctr: 204)] public igHandleMetaField _primitiveBudgetStat = new();
    }
}
