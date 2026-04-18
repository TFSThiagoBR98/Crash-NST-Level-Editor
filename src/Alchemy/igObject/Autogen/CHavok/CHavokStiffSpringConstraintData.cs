namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CHavokStiffSpringConstraintData : CHavokConstraintData
    {
        [FieldAttr(nst: 32)] public float _minLength;
        [FieldAttr(nst: 36)] public float _maxLength;
    }
}
