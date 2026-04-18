namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igNetReplicateAttribute : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _getter = null;
        [FieldAttr(nst: 24, ctr: 24)] public string? _setter = null;
        [FieldAttr(nst: 32, ctr: 32)] public float _precision;
        [FieldAttr(nst: 36, ctr: 36)] public float _min;
        [FieldAttr(nst: 40, ctr: 40)] public float _max;
        [FieldAttr(nst: 44, ctr: 44)] public bool _interpolate;
        [FieldAttr(nst: 45, ctr: 45)] public bool _extrapolate;
        [FieldAttr(nst: 46, ctr: 46)] public bool _supersample;
        [FieldAttr(nst: 48, ctr: 48)] public string? _predictor = null;
        [FieldAttr(nst: 56, ctr: 56)] public float _maxExtrapolationTime = 1.0f;
        [FieldAttr(nst: 60, ctr: 60)] public float _smoothing;
        [FieldAttr(nst: 64, ctr: 64)] public float _maxSmoothingDistance;
        [FieldAttr(nst: 68, ctr: 68)] public bool _dependency;
        [FieldAttr(nst: 69, ctr: 69)] public bool _timeShift;
    }
}
