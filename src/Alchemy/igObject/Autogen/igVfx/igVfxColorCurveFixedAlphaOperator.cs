namespace Alchemy
{
    [ObjectAttr(nst: 320, ctr: 320, align: 16)]
    public class igVfxColorCurveFixedAlphaOperator : igVfxColorBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVfxRgbCurveMetaField _colorCurve = new();
        [FieldAttr(nst: 304, ctr: 304)] public float _alpha = 1.0f;
        [FieldAttr(nst: 308, ctr: 308)] public EOperatorCurveInput _colorInput;
    }
}
