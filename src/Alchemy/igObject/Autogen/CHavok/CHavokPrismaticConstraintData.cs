namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CHavokPrismaticConstraintData : CHavokConstraintData
    {
        [FieldAttr(nst: 32)] public EConstraintAxis _movementAxis;
        [FieldAttr(nst: 36)] public EConstraintAxis _rotationAxis;
        [FieldAttr(nst: 40)] public bool _allowRotationAroundAxis;
    }
}
