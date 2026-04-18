namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVfxAccelerateDragRangeOperator : igVfxAccelerateDragBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igRangedFloatMetaField _drag = new();
    }
}
