namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 208, align: 8)]
    public class CVfxDrawTintSphereOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _intensity = new();
        [FieldAttr(nst: 116, ctr: 104)] public EOperatorCurveInput _intensityInput;
        [FieldAttr(nst: 120, ctr: 108)] public igVfxRangedCurveMetaField _additiveness = new();
        [FieldAttr(nst: 204, ctr: 192)] public EOperatorCurveInput _additivenessInput;
        [FieldAttr(nst: 208, ctr: 196)] public bool _depthBlendingEnabled;
        [FieldAttr(nst: 212, ctr: 200)] public float _depthBlendingSoftness = 14.0f;
        [FieldAttr(nst: 216, ctr: 204)] public uint _instance;
    }
}
