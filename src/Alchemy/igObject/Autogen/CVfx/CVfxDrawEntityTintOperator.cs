namespace Alchemy
{
    [ObjectAttr(nst: 312, ctr: 304, align: 8)]
    public class CVfxDrawEntityTintOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _colorIntensity = new();
        [FieldAttr(nst: 116, ctr: 104)] public EOperatorCurveInput _intensityInput;
        [FieldAttr(nst: 120, ctr: 108)] public igVfxRangedCurveMetaField _emissive = new();
        [FieldAttr(nst: 204, ctr: 192)] public EOperatorCurveInput _emissiveInput;
        [FieldAttr(nst: 208, ctr: 196)] public igVfxRangedCurveMetaField _emissiveBlend = new();
        [FieldAttr(nst: 292, ctr: 280)] public EOperatorCurveInput _blendInput;
        [FieldAttr(nst: 296, ctr: 284)] public float _priority;
        [FieldAttr(nst: 300, ctr: 288)] public bool _applyToBoltOns = true;
        [FieldAttr(nst: 304, ctr: 292)] public uint _instance;
        [FieldAttr(nst: 308, ctr: 296)] public uint _primitive;
    }
}
