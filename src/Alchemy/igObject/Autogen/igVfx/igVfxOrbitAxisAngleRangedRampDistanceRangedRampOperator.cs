namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class igVfxOrbitAxisAngleRangedRampDistanceRangedRampOperator : igVfxOrbitAxisAngleDistanceBaseOperator
    {
        [FieldAttr(ctr: 48)] public igVfxRangedRampMetaField _angle = new();
        [FieldAttr(ctr: 64)] public igVfxRangedRampMetaField _radius = new();
    }
}
