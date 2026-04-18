namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVfxVelocityLoadRangeOperator : igVfxVelocityLoadBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igRangedFloatMetaField _inheritedVelocity = new();
    }
}
