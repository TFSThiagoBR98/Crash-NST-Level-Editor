namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igVfxAlphaRangeOperator : igVfxAlphaBaseOperator
    {
        [FieldAttr(ctr: 20)] public igRangedFloatMetaField _alpha = new();
    }
}
