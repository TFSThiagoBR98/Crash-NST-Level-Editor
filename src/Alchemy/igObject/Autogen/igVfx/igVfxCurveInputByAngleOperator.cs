namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVfxCurveInputByAngleOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public ESourceAxis _instanceAxis = ESourceAxis.eSA_ZAxis;
            [FieldAttr(offset: 3, size: 1)] public bool _instanceFlip;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _referenceFrame = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 8, size: 3)] public ESourceAxis _referenceAxis = ESourceAxis.eSA_XAxis;
            [FieldAttr(offset: 11, size: 1)] public bool _referenceFlip;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
        [FieldAttr(nst: 28, ctr: 20)] public EOperatorCurveOutput _outputParameter = EOperatorCurveOutput.kSetTrackParameter1;
        [FieldAttr(nst: 32, ctr: 24)] public float _minAngle;
        [FieldAttr(nst: 36, ctr: 28)] public float _maxAngle = 180.0f;
    }
}
