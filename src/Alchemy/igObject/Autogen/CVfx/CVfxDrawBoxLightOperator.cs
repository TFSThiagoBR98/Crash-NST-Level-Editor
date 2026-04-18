namespace Alchemy
{
    [ObjectAttr(nst: 496, ctr: 480, align: 8)]
    public class CVfxDrawBoxLightOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _nearAttenuation = new();
        [FieldAttr(nst: 116, ctr: 104)] public igVfxRangedCurveMetaField _attenuation = new();
        [FieldAttr(nst: 200, ctr: 188)] public igVfxRangedCurveMetaField _xFalloff = new();
        [FieldAttr(nst: 284, ctr: 272)] public igVfxRangedCurveMetaField _yFalloff = new();
        [FieldAttr(nst: 368, ctr: 356)] public EOperatorCurveInput _attenuationInput;
        [FieldAttr(nst: 372, ctr: 360)] public igVfxRangedCurveMetaField _wrap = new();
        [FieldAttr(nst: 456, ctr: 444)] public EOperatorCurveInput _wrapInput;
        [FieldAttr(nst: 464, ctr: 448)] public string? _cookieTextureName = "loosetextures";
        [FieldAttr(nst: 472, ctr: 456)] public bool _distanceCull = true;
        [FieldAttr(nst: 480, ctr: 464)] public igVfxAnimatedFrame? _animatedFrame;
        [FieldAttr(nst: 488, ctr: 472)] public uint _instance;
    }
}
