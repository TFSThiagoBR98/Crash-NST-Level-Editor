namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 16)]
    public class igVfxSpinAxisRateRangeOperator : igVfxSpinAxisRateBaseOperator
    {
        [FieldAttr(nst: 64, ctr: 48)] public igRangedFloatMetaField _rate = new();
    }
}
