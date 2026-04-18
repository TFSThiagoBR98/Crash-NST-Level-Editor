namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 48, align: 8)]
    public class igVfxTranslateRangeOperator : igVfxFrameOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igRangedFloatMetaField _x = new();
        [FieldAttr(nst: 40, ctr: 28)] public igRangedFloatMetaField _y = new();
        [FieldAttr(nst: 48, ctr: 36)] public igRangedFloatMetaField _z = new();
        [FieldAttr(nst: 56, ctr: 44)] public EigVfxCurveCorrelation _correlation;
    }
}
