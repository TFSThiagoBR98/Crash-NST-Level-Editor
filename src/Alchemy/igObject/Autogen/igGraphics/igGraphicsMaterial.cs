namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 104, align: 8)]
    public class igGraphicsMaterial : igMaterial
    {
        [ObjectAttr(size: 4)]
        public class MaterialBitField : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public u8 _sortKey;
            [FieldAttr(offset: 4, size: 2)] public EigDrawType _drawType;
            [FieldAttr(offset: 6, size: 2)] public EigGraphicsMaterialAnimationTimeSource _timeSource;
        }

        [FieldAttr(nst: 24, ctr: 24)] public u64 _globalTechniqueMask;
        [FieldAttr(nst: 32, ctr: 32)] public MaterialBitField _materialBitField = new();
        [FieldAttr(nst: 36, ctr: 36)] public float _sortDepthOffset;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _effectHandle = new();
        [FieldAttr(nst: 48, ctr: 48)] public igMemoryCommandStream? _commonState;
        [FieldAttr(nst: 56, ctr: 56)] public igVectorMetaField<igMemoryCommandStream> _techniques = new();
        [FieldAttr(nst: 80, ctr: 80)] public igGraphicsMaterialAnimationList? _animations;
        [FieldAttr(nst: 88, ctr: 88)] public igGraphicsObjectSet? _graphicsObjects;
        [FieldAttr(ctr: 96)] public string? _fxMaterialMetaName;
    }
}
