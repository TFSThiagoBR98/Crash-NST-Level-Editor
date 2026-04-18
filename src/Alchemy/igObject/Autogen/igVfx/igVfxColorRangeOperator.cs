namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 16)]
    public class igVfxColorRangeOperator : igVfxColorBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _colorMin = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _colorMax = new();
    }
}
