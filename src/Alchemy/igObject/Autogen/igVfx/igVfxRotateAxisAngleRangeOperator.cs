namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 16)]
    public class igVfxRotateAxisAngleRangeOperator : igVfxRotateAxisAngleBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 48)] public igRangedFloatMetaField _angle = new();
    }
}
