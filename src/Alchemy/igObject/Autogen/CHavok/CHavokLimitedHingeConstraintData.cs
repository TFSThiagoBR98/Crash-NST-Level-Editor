namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CHavokLimitedHingeConstraintData : CHavokConstraintData
    {
        [FieldAttr(nst: 32)] public float _minAngle = -180.0f;
        [FieldAttr(nst: 36)] public float _maxAngle = 180.0f;
        [FieldAttr(nst: 40)] public float _angularStrengthFactor = 1.0f;
        [FieldAttr(nst: 44)] public float _maxFrictionTorque;
    }
}
