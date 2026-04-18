namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscConstColorAccessor : igVscColorAccessor
    {
        [FieldAttr(nst: 24, ctr: 14)] public igVec4ucMetaField _value = new();
    }
}
