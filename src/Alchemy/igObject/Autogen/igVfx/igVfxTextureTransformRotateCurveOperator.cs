namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class igVfxTextureTransformRotateCurveOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
        [FieldAttr(nst: 28, ctr: 20)] public igVec2fMetaField _pivot = new();
        [FieldAttr(nst: 36, ctr: 28)] public igVfxRangedCurveMetaField _angle = new();
        [FieldAttr(nst: 120, ctr: 112)] public EOperatorCurveInput _input;
    }
}
