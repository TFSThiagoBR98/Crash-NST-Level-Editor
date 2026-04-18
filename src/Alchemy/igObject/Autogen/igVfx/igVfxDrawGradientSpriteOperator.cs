namespace Alchemy
{
    [ObjectAttr(nst: 464, ctr: 448, align: 16)]
    public class igVfxDrawGradientSpriteOperator : igVfxDrawSpriteOperator
    {
        [ObjectAttr(size: 4)]
        public class SpriteFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _gradientFrame;
            [FieldAttr(offset: 4, size: 1)] public bool _useWorldUpAxis;
        }

        [FieldAttr(nst: 88, ctr: 64)] public SpriteFlags _spriteFlags = new();
        [FieldAttr(nst: 96, ctr: 80)] public igVfxRgbCurveMetaField _colorCurve = new();
        [FieldAttr(nst: 368, ctr: 352)] public igVfxRangedCurveMetaField _alpha = new();
        [FieldAttr(nst: 452, ctr: 436)] public EOperatorCurveInput _colorInput;
    }
}
