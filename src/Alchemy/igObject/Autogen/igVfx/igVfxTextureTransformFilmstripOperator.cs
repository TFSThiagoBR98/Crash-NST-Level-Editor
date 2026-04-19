namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class igVfxTextureTransformFilmstripOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
            [FieldAttr(offset: 2, size: 1)] public bool _wrapMode = false;
            [FieldAttr(offset: 3, size: 1)] public bool _bounceMode;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
        [FieldAttr(nst: 28, ctr: 20)] public igVfxRangedCurveMetaField _frame = new();
        [FieldAttr(nst: 112, ctr: 104)] public EOperatorCurveInput _input;
        [FieldAttr(nst: 116, ctr: 108)] public u8 _rows = 1;
        [FieldAttr(nst: 117, ctr: 109)] public u8 _columns = 1;
        [FieldAttr(nst: 118, ctr: 110)] public bool _useFrameRange;
        [FieldAttr(nst: 120, ctr: 112)] public uint _startFrame;
        [FieldAttr(nst: 124, ctr: 116)] public uint _endFrame;
    }
}
