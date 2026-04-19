namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 200, align: 8)]
    public class igVfxTextureTransformTranslateCurveOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
        [FieldAttr(nst: 28, ctr: 20)] public igVfxRangedCurveMetaField _uTranslate = new();
        [FieldAttr(nst: 112, ctr: 104)] public igVfxRangedCurveMetaField _vTranslate = new();
        [FieldAttr(nst: 196, ctr: 188)] public EOperatorCurveInput _input;
        [FieldAttr(nst: 200, ctr: 192)] public EigVfxCurveCorrelation _correlation;
    }
}
