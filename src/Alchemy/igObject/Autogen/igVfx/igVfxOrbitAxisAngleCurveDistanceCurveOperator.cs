namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 224, align: 16)]
    public class igVfxOrbitAxisAngleCurveDistanceCurveOperator : igVfxOrbitAxisAngleDistanceBaseOperator
    {
        [FieldAttr(nst: 64, ctr: 48)] public igVfxRangedCurveMetaField _angle = new();
        [FieldAttr(nst: 148, ctr: 132)] public EOperatorCurveInput _angleInput;
        [FieldAttr(nst: 152, ctr: 136)] public igVfxRangedCurveMetaField _radius = new();
        [FieldAttr(nst: 236, ctr: 220)] public EOperatorCurveInput _radiusInput;
    }
}
