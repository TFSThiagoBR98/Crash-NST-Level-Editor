namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 240, align: 4)]
    public class igVfxBudget : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public u8 _spawnGroupCount = 1;
        [FieldAttr(nst: 20, ctr: 16)] public uint _pghPoolSize = 32;
        [FieldAttr(nst: 24, ctr: 20)] public uint _geoAndMaterialPoolSize = 32;
        [FieldAttr(nst: 28, ctr: 24)] public uint _spawnedEffectPoolCapacity = 32;
        [FieldAttr(nst: 32, ctr: 28)] public uint _igVfxRangedCurveSpawnCountCount = 32;
        [FieldAttr(nst: 36, ctr: 32)] public uint _igVfxRangedCurveSpawnRateCount = 32;
        [FieldAttr(nst: 40, ctr: 36)] public uint _igVfxBoltCount = 32;
        [FieldAttr(nst: 44, ctr: 40)] public uint _igVfxSubEffectBoltCount = 32;
        [FieldAttr(nst: 48, ctr: 44)] public uint _igGuiPlaceableBoltCount = 32;
        [FieldAttr(nst: 52, ctr: 48)] public uint _igVfxBoxSpawnLocationCount = 32;
        [FieldAttr(nst: 56, ctr: 52)] public uint _igVfxCurveSpawnLocationCount = 32;
        [FieldAttr(nst: 60, ctr: 56)] public uint _igVfxCylindricalSpawnLocationCount = 32;
        [FieldAttr(nst: 64, ctr: 60)] public uint _igVfxSpawnLocationCount = 32;
        [FieldAttr(nst: 68, ctr: 64)] public uint _igVfxSphericalSpawnLocationCount = 32;
        [FieldAttr(nst: 72, ctr: 68)] public uint _igVfxCompositeSpawnLocationCount = 32;
        [FieldAttr(nst: 76, ctr: 72)] public uint _igVfxBezierCount = 32;
        [FieldAttr(nst: 80, ctr: 76)] public uint _igVfxBezierInstanceCount = 32;
        [FieldAttr(nst: 84, ctr: 80)] public uint _igVfxBezierWindingFlips = 3;
        [FieldAttr(nst: 88, ctr: 84)] public uint _igVfxCylinderCount = 32;
        [FieldAttr(nst: 92, ctr: 88)] public uint _igVfxCylinderInstanceCount = 32;
        [FieldAttr(nst: 96, ctr: 92)] public uint _igVfxCylinderWindingFlips = 3;
        [FieldAttr(nst: 100, ctr: 96)] public uint _igVfxDecalCount = 32;
        [FieldAttr(nst: 104, ctr: 100)] public uint _igVfxDecalInstanceCount = 32;
        [FieldAttr(nst: 108, ctr: 104)] public uint _igVfxDecalWindingFlips = 3;
        [FieldAttr(nst: 112, ctr: 108)] public uint _decalPoolCount = 32;
        [FieldAttr(nst: 116, ctr: 112)] public uint _igVfxLineCount = 32;
        [FieldAttr(nst: 120, ctr: 116)] public uint _igVfxLineInstanceCount = 32;
        [FieldAttr(nst: 124, ctr: 120)] public uint _igVfxLineWindingFlips = 3;
        [FieldAttr(nst: 128, ctr: 124)] public uint _igVfxModelCount = 32;
        [FieldAttr(nst: 132, ctr: 128)] public uint _igVfxModelInstanceCount = 32;
        [FieldAttr(nst: 136, ctr: 132)] public uint _modelPoolCount = 32;
        [FieldAttr(nst: 140, ctr: 136)] public uint _igVfxModelWindingFlips;
        [FieldAttr(nst: 144, ctr: 140)] public uint _igVfxOperatorPrimitiveCount = 32;
        [FieldAttr(nst: 148, ctr: 144)] public uint _igVfxOperatorPrimitiveInstanceCount = 32;
        [FieldAttr(nst: 152, ctr: 148)] public uint _igVfxOperatorPrimitiveWindingFlips;
        [FieldAttr(nst: 156, ctr: 152)] public uint _igVfxOperatorStorage1Count = 32;
        [FieldAttr(nst: 160, ctr: 156)] public uint _igVfxOperatorStorage2Count = 32;
        [FieldAttr(nst: 164, ctr: 160)] public uint _igVfxOperatorStorage3Count = 32;
        [FieldAttr(nst: 168, ctr: 164)] public uint _igVfxDrawSubEffectOperatorBoltCount = 32;
        [FieldAttr(nst: 172, ctr: 168)] public uint _igVfxDrawTrailControlPointArrayCount = 32;
        [FieldAttr(nst: 176, ctr: 172)] public uint _igVfxPlacedPrimitiveCount;
        [FieldAttr(nst: 180, ctr: 176)] public uint _igVfxPlacedPrimitiveInstanceCount;
        [FieldAttr(nst: 184, ctr: 180)] public uint _igVfxPlacedPrimitiveWindingFlips = 3;
        [FieldAttr(nst: 188, ctr: 184)] public uint _igVfxSpriteCount = 32;
        [FieldAttr(nst: 192, ctr: 188)] public uint _igVfxSpriteInstanceCount = 32;
        [FieldAttr(nst: 196, ctr: 192)] public uint _igVfxSpriteWindingFlips = 3;
        [FieldAttr(nst: 200, ctr: 196)] public uint _igVfxSubEffectCount = 32;
        [FieldAttr(nst: 204, ctr: 200)] public uint _igVfxSubEffectInstanceCount = 32;
        [FieldAttr(nst: 208, ctr: 204)] public uint _igVfxSubEffectWindingFlips;
        [FieldAttr(nst: 212, ctr: 208)] public uint _igVfxTrailCount = 32;
        [FieldAttr(nst: 216, ctr: 212)] public uint _igVfxTrailInstanceCount = 32;
        [FieldAttr(nst: 220, ctr: 216)] public uint _igVfxTrailWindingFlips = 3;
        [FieldAttr(nst: 224, ctr: 220)] public uint _igVfxTrailControlPointArrayCount = 32;
        [FieldAttr(nst: 228, ctr: 224)] public uint _igVfxDataBlockCount;
        [FieldAttr(nst: 232, ctr: 228)] public uint _streamHeapBlockSize = 512;
        [FieldAttr(nst: 236, ctr: 232)] public uint _streamHeapTotalSize = 65536;
    }
}
