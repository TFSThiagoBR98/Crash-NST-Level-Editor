namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class igVscSineAccessor : igVscFloatAccessor
    {
        [FieldAttr(ctr: 16)] public igVscFloatAccessor? _angle;
    }
}
