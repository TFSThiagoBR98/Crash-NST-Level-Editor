namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class igSoundUpdateMethodVolumeByListenerRelativeVelocity : igSoundUpdateMethod
    {
        [FieldAttr(ctr: 16)] public igListenerRelativeAbsoluteVelocityFrameReference? _frameReference;
        [FieldAttr(ctr: 24)] public igVolumeApplicator? _applicator;
        [FieldAttr(ctr: 32)] public float _minRange;
        [FieldAttr(ctr: 36)] public float _maxRange;
        [FieldAttr(ctr: 40)] public float _valueAtMinRange;
        [FieldAttr(ctr: 44)] public float _valueAtMaxRange;
    }
}
