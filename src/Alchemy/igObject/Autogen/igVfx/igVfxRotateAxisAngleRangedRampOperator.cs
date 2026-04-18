namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 16)]
    public class igVfxRotateAxisAngleRangedRampOperator : igVfxRotateAxisAngleBaseOperator
    {
        [FieldAttr(nst: 48)] public igVfxRangedRampMetaField _angle = new();
    }
}
