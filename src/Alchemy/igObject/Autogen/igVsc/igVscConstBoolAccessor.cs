namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 16, align: 4)]
    public class igVscConstBoolAccessor : igVscBoolAccessor
    {
        [FieldAttr(nst: 24, ctr: 14)] public bool _value;
    }
}
