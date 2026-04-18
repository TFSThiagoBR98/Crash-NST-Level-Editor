namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igCustomMaterial : igMaterial
    {
        [ObjectAttr(size: 4)]
        public class CustomMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EIG_GFX_ALPHA_FUNCTION _alphaFunction;
            [FieldAttr(offset: 3, size: 1)] public bool _alphaTestState;
            [FieldAttr(offset: 4, size: 4)] public EIG_GFX_BLENDING_FUNCTION _blendingSource;
            [FieldAttr(offset: 8, size: 4)] public EIG_GFX_BLENDING_FUNCTION _blendingDestination;
            [FieldAttr(offset: 12, size: 3)] public EIG_GFX_BLENDING_EQUATION _blendingEquation;
            [FieldAttr(offset: 15, size: 1)] public bool _blendingState;
            [FieldAttr(offset: 16, size: 1)] public EIG_GFX_CULL_FACE_MODE _cullFaceMode;
            [FieldAttr(offset: 17, size: 1)] public bool _cullFaceState;
            [FieldAttr(offset: 18, size: 1)] public bool _depthTestState;
            [FieldAttr(offset: 19, size: 1)] public bool _depthWriteState;
            [FieldAttr(offset: 20, size: 3)] public EIG_GFX_TEXTURE_WRAP _wrapS;
            [FieldAttr(offset: 23, size: 3)] public EIG_GFX_TEXTURE_WRAP _wrapT;
            [FieldAttr(offset: 26, size: 4)] public u8 _sortKey;
            [FieldAttr(offset: 30, size: 1)] public bool _prepareAffectsRenderState;
        }

        [ObjectAttr(size: 2)]
        public class CustomMaterialBitfield2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _dirty;
            [FieldAttr(offset: 1, size: 4)] public EIG_GFX_TEXTURE_FILTER _magnificationFilter;
            [FieldAttr(offset: 5, size: 4)] public EIG_GFX_TEXTURE_FILTER _minificationFilter;
            [FieldAttr(offset: 9, size: 2)] public EigCustomMaterialAnimationTimeSource _timeSource;
            [FieldAttr(offset: 10, size: 1)] public bool _unknown;
            [FieldAttr(offset: 11, size: 1)] public bool _unknown1;
            [FieldAttr(offset: 12, size: 1)] public bool _unknown2;
        }

        [ObjectAttr(size: 2)]
        public class CustomMaterialPreparedBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _useDefaultAlphaFunctionAttr;
            [FieldAttr(offset: 1, size: 1)] public bool _useDefaultAlphaStateAttr;
            [FieldAttr(offset: 2, size: 1)] public bool _useDefaultBlendFunctionAttr;
            [FieldAttr(offset: 3, size: 1)] public bool _useDefaultBlendStateAttr;
            [FieldAttr(offset: 4, size: 1)] public bool _useDefaultCullFaceAttr;
            [FieldAttr(offset: 5, size: 1)] public bool _useDefaultDecalAttr;
            [FieldAttr(offset: 6, size: 1)] public bool _useDefaultDepthStateAttr;
            [FieldAttr(offset: 7, size: 1)] public bool _useDefaultDepthWriteStateAttr;
            [FieldAttr(offset: 8, size: 1)] public bool _unknown;
        }

        [FieldAttr(nst: 24, ctr: 24)] public igCustomMaterialAnimationList? _transforms;
        [FieldAttr(nst: 32, ctr: 32)] public CustomMaterialBitfield _customMaterialBitfield = new();
        [FieldAttr(nst: 36, ctr: 36)] public CustomMaterialBitfield2 _customMaterialBitfield2 = new();
        [FieldAttr(nst: 38, ctr: 38)] public CustomMaterialPreparedBitfield _customMaterialPreparedBitfield = new();
        [FieldAttr(nst: 40, ctr: 40)] public float _alphaRefValue = 0.5f;
        [FieldAttr(nst: 44, ctr: 44)] public float _depthBias;
        [FieldAttr(nst: 48, ctr: 48)] public float _slopeScaleDepthBias;
        [FieldAttr(nst: 56, ctr: 56)] public igAttrList? _renderState;
    }
}
