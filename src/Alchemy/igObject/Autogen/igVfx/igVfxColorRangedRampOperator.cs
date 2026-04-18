namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 16)]
    public class igVfxColorRangedRampOperator : igVfxColorBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _colorMinStart = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _colorMaxStart = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _colorMinEnd = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _colorMaxEnd = new();
    }
}
