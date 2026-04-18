namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscConstFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _value;
    }
}
