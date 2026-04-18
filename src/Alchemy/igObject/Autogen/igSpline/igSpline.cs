namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igSpline : igSplinePointList
    {
        public enum ESplineInterpolationMode
        {
            eSIM_Curved = 0,
            eSIM_CurvedBezier = 1,
            eSIM_Linear = 2,
        }

        public enum ERotationMode
        {
            kTangent = 0,
            kInterpolated = 1,
        }

        [FieldAttr(nst: 40, ctr: 40)] public float _length;
        [FieldAttr(nst: 44, ctr: 44)] public ESplineInterpolationMode _mode;
        [FieldAttr(nst: 48, ctr: 48)] public ERotationMode _rotationMode = igSpline.ERotationMode.kInterpolated;
        [FieldAttr(nst: 52, ctr: 52)] public bool _loopControlPoints;
        [FieldAttr(nst: 56, ctr: 56)] public float _tensionParameter = 0.4f;
    }
}
