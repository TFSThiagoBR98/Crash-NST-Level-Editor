namespace Alchemy
{
    [ObjectAttr(nst: 216, ctr: 208, align: 8)]
    public class igVfxTextureTransformScaleCurveOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
        [FieldAttr(nst: 28, ctr: 20)] public igVec2fMetaField _pivot = new();
        [FieldAttr(nst: 36, ctr: 28)] public igVfxRangedCurveMetaField _uScale = new();
        [FieldAttr(nst: 120, ctr: 112)] public igVfxRangedCurveMetaField _vScale = new();
        [FieldAttr(nst: 204, ctr: 196)] public EOperatorCurveInput _input;
        [FieldAttr(nst: 208, ctr: 200)] public EigVfxCurveCorrelation _correlation;
    }
}
