namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CVfxDrawModelOperator : igVfxDrawOperator
    {
        public enum EDrawMode
        {
            kDrawModeAuto = 0,
            kDrawModeHudPortrait1 = 1,
            kDrawModeHudPortrait2 = 2,
        }

        [ObjectAttr(size: 4)]
        public class ModelFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isSkinned;
            [FieldAttr(offset: 1, size: 1)] public bool _fitToScale;
            [FieldAttr(offset: 2, size: 1)] public bool _keepAspectRatio = false;
            [FieldAttr(offset: 3, size: 1)] public bool _useBoltAnimation;
            [FieldAttr(offset: 4, size: 1)] public bool _useAlphaForFade = false;
            [FieldAttr(offset: 5, size: 2)] public CVfxDrawModelOperator.EDrawMode _drawMode;
        }

        [FieldAttr(nst: 32, ctr: 24)] public string? _modelName = null;
        [FieldAttr(nst: 40, ctr: 32)] public string? _animationName = null;
        [FieldAttr(nst: 48, ctr: 40)] public string? _animationSourceModelName = null;
        [FieldAttr(nst: 56, ctr: 48)] public ModelFlags _modelFlags = new();
        [FieldAttr(nst: 64, ctr: 56)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _modelCacheHandle = new();
        [FieldAttr(nst: 80, ctr: 72)] public uint _instance;
    }
}
