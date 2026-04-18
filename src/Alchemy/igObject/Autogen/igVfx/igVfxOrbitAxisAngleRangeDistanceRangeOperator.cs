namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 16)]
    public class igVfxOrbitAxisAngleRangeDistanceRangeOperator : igVfxOrbitAxisAngleDistanceBaseOperator
    {
        [FieldAttr(ctr: 48)] public igRangedFloatMetaField _angle = new();
        [FieldAttr(ctr: 56)] public igRangedFloatMetaField _radius = new();
    }
}
