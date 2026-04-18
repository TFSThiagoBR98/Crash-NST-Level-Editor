namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 16)]
    public class igVfxCurveInputByPlaneDistanceOperator : igVfxFrameOperator
    {
        [FieldAttr(ctr: 20)] public EOperatorCurveOutput _outputParameter;
        [FieldAttr(ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(ctr: 48)] public float _minDistance;
        [FieldAttr(ctr: 52)] public float _maxDistance;
    }
}
