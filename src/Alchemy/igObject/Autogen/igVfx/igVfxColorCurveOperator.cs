namespace Alchemy
{
    [ObjectAttr(nst: 400, ctr: 400, align: 16)]
    public class igVfxColorCurveOperator : igVfxColorBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVfxRgbCurveMetaField _colorCurve = new();
        [FieldAttr(nst: 304, ctr: 304)] public igVfxRangedCurveMetaField _alpha = new();
        [FieldAttr(nst: 388, ctr: 388)] public EOperatorCurveInput _colorInput;
    }
}
